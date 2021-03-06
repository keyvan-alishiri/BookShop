﻿using BookShop.Areas.Admin.Data;
using BookShop.Areas.Identity.Data;
using BookShop.Areas.Identity.Services;
using BookShop.Classes;
using BookShop.Models;
using BookShop.Models.UnitOfWork;
using BookShop.Models.ViewModels;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace BookShop.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class AccountController : Controller
    {
        private readonly IApplicationRoleManager _roleManager;
        private readonly IApplicationUserManager _userManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly IConfiguration _configuration;

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ConvertDate _convertDate;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AccountController> _Logger;
        private readonly IHttpContextAccessor _Accessor;

        public AccountController(IApplicationRoleManager roleManager, IApplicationUserManager userManager, IEmailSender emailSender, SignInManager<ApplicationUser> signInManager, ISmsSender smsSender, IConfiguration configuration, ConvertDate convertDate, IUnitOfWork unitOfWork , ILogger<AccountController> Logger, IHttpContextAccessor Accessor)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _emailSender = emailSender;
            _signInManager = signInManager;
            _smsSender = smsSender;
            _configuration = configuration;
            _convertDate = convertDate;
            _unitOfWork = unitOfWork;
            _Logger = Logger;
            _Accessor = Accessor;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel ViewModel)
        {
            if (ModelState.IsValid)
            {
                DateTime BirthDateMiladi = _convertDate.ConvertShamsiToMiladi(ViewModel.BirthDate);
                var user = new ApplicationUser { UserName = ViewModel.UserName, Email = ViewModel.Email, PhoneNumber = ViewModel.PhoneNumber, RegisterDate = DateTime.Now, IsActive = true , BirthDate= BirthDateMiladi };
                IdentityResult result = await _userManager.CreateAsync(user, ViewModel.Password);

                if (result.Succeeded)
                {
                    var role = _roleManager.FindByNameAsync("کاربر");
                    if (role == null)
                        await _roleManager.CreateAsync(new ApplicationRole("کاربر"));

                    result = await _userManager.AddToRoleAsync(user, "کاربر");
                    await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.DateOfBirth, BirthDateMiladi.ToShortDateString()));

                    if (result.Succeeded)
                    {
                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        var callbackUrl = Url.Action("ConfirmEmail", "Account", values: new { userId = user.Id, code = code }, protocol: Request.Scheme);

                        await _emailSender.SendEmailAsync(ViewModel.Email, "تایید ایمیل حساب کاربری - سایت میزفا", $"<div dir='rtl' style='font-family:tahoma;font-size:14px'>لطفا با کلیک روی لینک رویه رو ایمیل خود را تایید کنید.  <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>کلیک کنید</a></div>");

                        return RedirectToAction("Index", "Home", new { id = "ConfirmEmail" });
                    }
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
            }

            return View();
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
                return RedirectToAction("Index", "Home");

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return NotFound($"Unable to load user with ID '{userId}'");

            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (!result.Succeeded)
                throw new InvalidOperationException($"Error Confirming email for user with ID '{userId}'");

            return View();
        }

        [HttpGet]
        public IActionResult SignIn(string ReturnUrl=null)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignInViewModel ViewModel)
        {

            if (Captcha.ValidateCaptchaCode(ViewModel.CaptchaCode, HttpContext))
            {
                if (ModelState.IsValid)
                {

                    var user = await _userManager.FindByNameAsync(ViewModel.UserName);
                    if (user != null)
                    {
                        if (user.IsActive)
                        {
                            var result = await _signInManager.PasswordSignInAsync(ViewModel.UserName, ViewModel.Password, ViewModel.RememberMe, true);
                            if (result.Succeeded)
                            {
                                return RedirectToAction("Index", "Home");
                            }
                            if (result.IsLockedOut)
                            {
                                ModelState.AddModelError(String.Empty, "حساب کاربری شما به دلیل تلاش های ناموفق به مدت 20 دقیقه قفل شد.");
                                return View();
                            }

                            if (result.RequiresTwoFactor)
                                return RedirectToAction("SendCode", new { RememberMe = ViewModel.RememberMe });
                        }
                    }

                    _Logger.LogWarning($"The user attempts to login with the IP address({_Accessor.HttpContext?.Connection?.RemoteIpAddress.ToString()}) and username ({ViewModel.UserName}) and password ({ViewModel.Password}).");

                    ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور شما صحیح نمی باشد.");
                }
            }

            else
            {
                ModelState.AddModelError(string.Empty, "کد امنیتی صحیح نمی باشد.");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignOut()
        {
            var user = await _userManager.GetUserAsync(User);
            user.LastVisitDateTime = DateTime.Now;
            await _userManager.UpdateAsync(user);
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Route("get-captcha-image")]
        public IActionResult GetCaptchaImage()
        {
            int width = 100;
            int height = 36;
            var captchaCode = Captcha.GenerateCaptchaCode();
            var result = Captcha.GenerateCaptchaImage(width, height, captchaCode);
            HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
            Stream s = new MemoryStream(result.CaptchaByteData);

            return new FileStreamResult(s, "image/png");

        }

        [HttpGet]

        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel ViewModel)
        {
            if (ModelState.IsValid)
            {
                var User = await _userManager.FindByEmailAsync(ViewModel.Email);
                if (User == null)
                    ModelState.AddModelError(string.Empty, "ایمیل شما صحیح نمی باشد.");
                else
                {
                    if (!await _userManager.IsEmailConfirmedAsync(User))
                        ModelState.AddModelError(string.Empty, "لطفا با تایید ایمیل حساب کاربری خود را فعال کنید.");
                    else
                    {
                        var Code = await _userManager.GeneratePasswordResetTokenAsync(User);
                        var CallbackUrl = Url.Action("ResetPassword", "Account", values: new { Code }, protocol: Request.Scheme);
                        await _emailSender.SendEmailAsync(ViewModel.Email, "بازیابی کلمه عبور", $"<p style='font-family:tahoma;font-size:14px'> برای بازنشانی کلمه عبور خود <a href='{HtmlEncoder.Default.Encode(CallbackUrl)}'>اینجا کلیک کنید</a> </p>");

                        return RedirectToAction("ForgetPasswordConfirmation");
                    }
                }
            }

            return View(ViewModel);
        }

        [HttpGet]
        public IActionResult ForgetPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string Code = null)
        {
            if (Code == null)
                return NotFound();
            else
            {
                var ViewModel = new ResetPasswordViewModel { Code = Code };
                return View(ViewModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel ViewModel)
        {
            if (ModelState.IsValid)
            {
                var User = await _userManager.FindByEmailAsync(ViewModel.Email);
                if (User == null)
                    ModelState.AddModelError(string.Empty, "ایمیل شما صحیح نمی باشد.");

                else
                {
                    var Result = await _userManager.ResetPasswordAsync(User, ViewModel.Code, ViewModel.Password);
                    if (Result.Succeeded)
                        return RedirectToAction("ResetPasswordConfirmation");
                    else
                    {
                        foreach (var error in Result.Errors)
                            ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(ViewModel);
        }

        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        public async Task<IActionResult> SendSms()
        {
            string status = await _smsSender.SendAuthSmsAsync("1361", "09190000000");
            if (status == "success")
                ViewBag.Alert = "ارسال پیامک با موفقیت انجام شد.";
            else
                ViewBag.Alert = "در ارسال پیامک خطایی رخ داده است";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SendCode(bool RememberMe)
        {
            var FactorOptions = new List<SelectListItem>();
            var User = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (User == null)
                return NotFound();

            var UserFactors = await _userManager.GetValidTwoFactorProvidersAsync(User);
            //  UserFactors.Add("Authenticator");
            foreach (var item in UserFactors)
            {
                if (item == "Authenticator")
                {
                    FactorOptions.Add(new SelectListItem { Text = "اپلیکیشن احراز هویت", Value = item });
                }

                else
                {
                    FactorOptions.Add(new SelectListItem { Text = (item == "Email" ? "ارسال ایمیل" : "ارسال پیامک"), Value = item });
                }
            }



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Before implementing the authenticator use Code For Disable Authenticator
            // UserFactors.Remove("Authenticator");  
            // var FactorOptions = UserFactors.Select(p => new SelectListItem { Text = (p == "Email" ? "ارسال ایمیل" : "ارسال پیامک"), Value = p }).ToList();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            return View(new SendCodeViewModel { Providers = FactorOptions, RememberMe = RememberMe });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendCode(SendCodeViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ViewModel);
            }

            var User = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (User == null)
                return NotFound();

            if (ViewModel.SelectedProvider != "Authenticator")
            {
                var Code = await _userManager.GenerateTwoFactorTokenAsync(User, ViewModel.SelectedProvider);
                if (string.IsNullOrWhiteSpace(Code))
                    return View("Error");

                var Message = "<p style='direction:rtl;font-size:14px;font-family:tahoma'>کد اعتبارسنجی شما :" + Code + "</p>";

                if (ViewModel.SelectedProvider == "Email")
                    await _emailSender.SendEmailAsync(User.Email, "کد اعتبارسنجی", Message);

                else if (ViewModel.SelectedProvider == "Phone")
                {
                    string ResponseSms = await _smsSender.SendAuthSmsAsync(Code, User.PhoneNumber);
                    if (ResponseSms == "Failed")
                    {
                        ModelState.AddModelError(string.Empty, "در ارسال پیامک خطایی رخ داده است.");
                        return View(ViewModel);
                    }

                }

                return RedirectToAction("VerifyCode", new { Provider = ViewModel.SelectedProvider, RememberMe = ViewModel.RememberMe });

            }

            else
                return RedirectToAction("LoginWith2fa", new { RememberMe = ViewModel.RememberMe });

        }

        [HttpGet]
        public async Task<IActionResult> LoginWith2fa(bool RememberMe)
        {
            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
                return NotFound();

            return View(new LoginWith2faViewModel { RememberMe = RememberMe });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginWith2fa(LoginWith2faViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            else
            {
                var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
                if (user == null)
                    return NotFound();

                var authenticationCode = ViewModel.TwoFactorCode.Replace(" ", String.Empty).Replace("-", string.Empty);
                var Result = await _signInManager.TwoFactorAuthenticatorSignInAsync(authenticationCode, ViewModel.RememberMe, ViewModel.RememberMachine);
                if (Result.Succeeded)
                    return RedirectToAction("Index", "Home");
                else if (Result.IsLockedOut)
                    ModelState.AddModelError(string.Empty, "حساب کاربری شما به دلیل تلاش های ناموفق به مدت 20 دقیقه قفل شد.");
                else
                    ModelState.AddModelError(string.Empty, "کداعتبارسنجی شما نامعتبر است.");

                return View(ViewModel);
            }
        }


        [HttpGet]
        public async Task<IActionResult> VerifyCode(string Provider, bool RememberMe)
        {
            var User = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (User == null)
                return NotFound();
            return View(new VerifyCodeViewModel { Provider = Provider, RememberMe = RememberMe });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyCode(VerifyCodeViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ViewModel);
            }

            var Result = await _signInManager.TwoFactorSignInAsync(ViewModel.Provider, ViewModel.Code, ViewModel.RememberMe, ViewModel.RememberBrowser);
            if (Result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            else if (Result.IsLockedOut)
            {
                ModelState.AddModelError(string.Empty, "حساب کاربری شما به دلیل تلاش های ناموفق به مدت 20 دقیقه قفل شد.");
            }

            else
            {
                ModelState.AddModelError(string.Empty, "کد اعتبارسنجی صحیح نمی باشد");
            }

            return View(ViewModel);

        }


        
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ChangePassword()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return NotFound();
            UserSidebarViewModel Sidebar = new UserSidebarViewModel()
            {
                FullName = user.FirstName + " " + user.LastName,
                LastVisit = user.LastVisitDateTime,
                RegisterDate = user.RegisterDate,
                Image = user.Image,
            };
            return View(new ChangePasswordViewModel { UserSidebar = Sidebar });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel ViewModel)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                var ChangePassResult = await _userManager.ChangePasswordAsync(user, ViewModel.OldPassword, ViewModel.NewPassword);
                if (ChangePassResult.Succeeded)
                    ViewBag.Alert = "کلمه عبور شما با موفقیت تغییر یافت.";

                else
                {
                    foreach (var item in ChangePassResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                    }
                }
            }

            UserSidebarViewModel Sidebar = new UserSidebarViewModel()
            {
                FullName = user.FirstName + " " + user.LastName,
                LastVisit = user.LastVisitDateTime,
                RegisterDate = user.RegisterDate,
                Image = user.Image,
            };

            ViewModel.UserSidebar = Sidebar;
            return View(ViewModel);
        }


        [HttpGet]
        public async Task<IActionResult> LoginWithRecoveryCode()
        {
            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
                return NotFound();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginWithRecoveryCode(LoginWithRecoveryCodeViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ViewModel);
            }

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
                return NotFound();

            var RecoveryCode = ViewModel.RecoveryCode.Replace(" ", string.Empty);
            var Result = await _signInManager.TwoFactorRecoveryCodeSignInAsync(RecoveryCode);
            if (Result.Succeeded)
                return RedirectToAction("Index", "Home");

            else if (Result.IsLockedOut)
                ModelState.AddModelError(string.Empty, "حساب کاربری شما به مدت 20 دقیقه به دلیل تلاش های ناموفق قفل شد.");

            else
                ModelState.AddModelError(string.Empty, "کد بازیابی شما نامعتبر است.");

            return View(ViewModel);
        }

        [HttpPost]
        public IActionResult GetExternalLoginProvider(string provider)
        {
            if (provider == "Yahoo")
            {
                var client_id = _configuration.GetValue<string>("YahooOAuth:ClientID");

                //for host
                //var redirectUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/yahoo-signin";
               // return Redirect($"https://api.login.yahoo.com/oauth2/request_auth?client_id={client_id}&redirect_uri=https://c4aedefa.ngrok.io/yahoo-signin&response_type=code&language=en-us");
                return Redirect($"https://api.login.yahoo.com/oauth2/request_auth?client_id={client_id}&redirect_uri=https://bb8fb842a6df.ngrok.io/yahoo-signin&response_type=code&language=en-us");

            }
            var RedirectUrl = Url.Action("GetCallBackAsync", "Account");
            var Properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, RedirectUrl);
            return Challenge(Properties, provider);
        }

        public async Task<IActionResult> GetCallBackAsync()
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                ModelState.AddModelError(string.Empty, $"در عملیات ورود به سایت از طریق حساب {info.ProviderDisplayName} خطایی رخ داده است. ");

            var UserEmail = info.Principal.FindFirstValue(ClaimTypes.Email);
            var user = await _userManager.FindByEmailAsync(UserEmail);
            if (user == null)
                ModelState.AddModelError(string.Empty, "شما عضو سایت نیستید برای ورود به سایت ابتدا باید عضو سایت شوید.");

            else
            {
                var Result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
                if (Result.Succeeded)
                    return RedirectToAction("Index", "Home");

                else if (Result.IsLockedOut)
                {
                    ModelState.AddModelError(string.Empty, "حساب کاربری شما به مدت 20 دقیقه به دلیل تلاش های ناموفق قفل شد.");
                }

                else if (Result.RequiresTwoFactor)
                    return RedirectToAction("SendCode");

                else
                {
                    var ExternalResult = await _userManager.AddLoginAsync(user, info);
                    if (ExternalResult.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, false);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            return View("SignIn");
        }


        //[Route("yahoo-signin")]
        //public async Task<IActionResult> GetYahooCallBackAsync(string code, string state)
        //{
        //    HttpClient httpClient = new HttpClient();

        //    //for host
        //    //var redirectUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/yahoo-signin";

        //    Dictionary<string, string> param = new Dictionary<string, string>();
        //    param.Add("client_id", _configuration.GetValue<string>("YahooOAuth:ClientID"));
        //    param.Add("client_secret", _configuration.GetValue<string>("YahooOAuth:ClientSecret"));

        //    //for host
        //    //param.Add("redirect_uri", redirectUrl);

        //    param.Add("redirect_uri", "https://c4aedefa.ngrok.io/yahoo-signin");
        //    param.Add("code", code);
        //    param.Add("grant_type", "authorization_code");

        //    FormUrlEncodedContent formatContent = new FormUrlEncodedContent(param);

        //    var response = await httpClient.PostAsync("https://api.login.yahoo.com/oauth2/get_token", formatContent);

        //    if (response.StatusCode == HttpStatusCode.OK)
        //    {
        //        string JsonResponse = response.Content.ReadAsStringAsync().Result;
        //        dynamic JsonData = JsonConvert.DeserializeObject(JsonResponse);
        //        string Token = JsonData.access_token;
        //        string Guid = JsonData.xoauth_yahoo_guid;

        //        var Request = new HttpRequestMessage(HttpMethod.Get, "https://social.yahooapis.com/v1/user/me/profile?format=json");
        //        Request.Headers.Add("Authorization", $"Bearer {Token}");
        //        var MyClient = _httpClientFactory.CreateClient();
        //        response = await MyClient.SendAsync(Request);

        //        if (response.StatusCode == HttpStatusCode.OK)
        //        {
        //            JsonResponse = response.Content.ReadAsStringAsync().Result;
        //            JsonData = JsonConvert.DeserializeObject(JsonResponse);

        //            string email = JsonData.profile.emails[0].handle;
        //            var Claim = new List<Claim> { new Claim(ClaimTypes.Email, email) };
        //            var ClaimIdentity = new ClaimsIdentity(Claim);
        //            var Info = new ExternalLoginInfo(new ClaimsPrincipal(ClaimIdentity), "Yahoo", Guid, "Yahoo");

        //            var Result = await ExternalLoginAsync(Info);
        //            if (Result == "success")
        //                return RedirectToAction("Index", "Home");

        //            else if (Result == "requiresTwoFactor")
        //                return RedirectToAction("SendCode");

        //            else
        //            {
        //                ModelState.AddModelError(string.Empty, Result);
        //                return View("SignIn");
        //            }
        //        }

        //    }

        //    ModelState.AddModelError(string.Empty, "در ورود به سایت از طریق اکانت یاهو خطایی رخ داده است.");
        //    return View("SignIn");
        //}

        public IActionResult AccessDenied(string  ReturnUrl=null)
        {
            return View();
        }


        [Authorize(Policy = "HappyBirthDay")]
        public  IActionResult HappyBirthDay()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return NotFound();

            UserSidebarViewModel Sidebar = new UserSidebarViewModel()
            {
                FullName = user.FirstName + " " + user.LastName,
                LastVisit = user.LastVisitDateTime,
                RegisterDate = user.RegisterDate,
                Image = user.Image,
            };

            ViewBag.CityID = new SelectList( _unitOfWork.BaseRepository<City>().FindAll(), "CityID", "CityName");
            ViewBag.ProvinceID = new SelectList(_unitOfWork.BaseRepository<Provice>().FindAll(), "ProvinceID", "ProvinceName");
            return View(new ProfileViewModel { UserSidebar = Sidebar });
        }


        public async Task<IActionResult> UpdateCity(int id)
        {
            var Cities = await _unitOfWork.BaseRepository<City>().FindByConditionAsync(p => p.ProvinceID == id);
            return Json(JsonConvert.SerializeObject(Cities));
        }

    }
}