using BookShop.Areas.Admin.Data;
using BookShop.Areas.Api.Attributes;
using BookShop.Areas.Api.Classes;
using BookShop.Areas.Api.Services;
using BookShop.Areas.Identity.Data;
using BookShop.Models.Repository;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookShop.Areas.Api.Controllers.v1
{
    // [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiResultFilter]
    [ApiVersion("1")]
    public class UsersApiController : ControllerBase
    {
        private readonly IApplicationUserManager _userManager;
        private readonly IUsersRepository _usersRpository;
        private readonly IjwtService _jwtService;

        public UsersApiController(IApplicationUserManager userManager,  IUsersRepository usersRpository, IjwtService jwtService)
        {
            _userManager = userManager;
            _usersRpository = usersRpository;
            _jwtService = jwtService;
        }

        //[HttpGet]
        //public async Task<List<UsersViewModel>> Get()
        //{
        //    return await _userManager.GetAllUsersWithRolesAsync();
        //}

        [HttpGet]
        // [Authorize]
        // [Authorize(Roles ="مدیر سایت")]
       // [Authorize(Policy = (ConstantPolicies.DynamicPermission), AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

        [JwtAuthentication(Policy = ConstantPolicies.DynamicPermission)]    //After create JwtAuthenticationAttribute class for one Customize Attribute
        public virtual async Task<ApiResult<List<UsersViewModel>>> Get()
        {
            //string UserName = HttpContext.User.Identity.Name;
            //string PhoneNumber = HttpContext.User.FindFirstValue(ClaimTypes.MobilePhone);
            return Ok( await _userManager.GetAllUsersWithRolesAsync());
        }

        //[HttpGet("{id}")]
        ////[HttpGet("[action]")]
        //public async Task<IActionResult> Get(string id)
        //{
        //    var User = await _userManager.FindUserWithRolesByIdAsync(id);
        //    if (User == null)
        //        return NotFound();
        //    else
        //        return new JsonResult(User);
        //}



        [HttpGet("{id}")]
        //[HttpGet("[action]")]
        public virtual async Task<ApiResult<UsersViewModel>> Get(string id)
        {
            var User = await _userManager.FindUserWithRolesByIdAsync(id);
            if (User == null)
                return NotFound();
            else
                return Ok(User);
        }




        //[HttpPost("[Action]")]
        //public async Task<JsonResult> Register(RegisterBaseViewModel viewModel)
        //{
        //    var result = await _usersRpository.RegisterAsync(viewModel);

        //    if (result.Succeeded)
        //    {

        //        return new JsonResult("عضویت با موفقیت انجام شد");

        //    }
        //    else
        //        return new JsonResult(result.Errors);
        // }



        [HttpPost("[Action]")]
        public virtual async Task<ApiResult<string>> Register(RegisterBaseViewModel viewModel)
        {
            var result = await _usersRpository.RegisterAsync(viewModel);

            if (result.Succeeded)
            {

                return Ok("عضویت با موفقیت انجام شد");

            }
            else
                return BadRequest(result.Errors);
        }



        //[HttpPost("[Action]")]
        //public async Task<string> SignIn(SignInBaseViewModel viewModel)
        //{
        //    var User = await _userManager.FindByNameAsync(viewModel.UserName);
        //    if (User == null)
        //        return "کاربری با این ایمیل یافت نشد";
        //    else
        //    {
        //        var result = await _userManager.CheckPasswordAsync(User, viewModel.Password);
        //        if (result)
        //            return "اهراز هویت با موفقیت انجام شد";
        //        else
        //            return "نام کاربری یا کبمه عبور شما صحیح نمی باشد";
        //    }

        //}

        [HttpPost("[Action]")]
        public virtual async Task<ApiResult<string>> SignIn(SignInBaseViewModel viewModel)
        {
            var User = await _userManager.FindByNameAsync(viewModel.UserName);
            if (User == null)
                return BadRequest("کاربری با این ایمیل یافت نشد");
            else
            {
                var result = await _userManager.CheckPasswordAsync(User, viewModel.Password);
                if (result)
                    return Ok(await _jwtService.GenerateTokenAsync(User));
                else
                    return BadRequest("نام کاربری یا کلمه عبور شما صحیح نمی باشد");
            }

        }
    }
}