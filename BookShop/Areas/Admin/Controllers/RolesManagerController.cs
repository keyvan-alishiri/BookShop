using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Areas.Admin.Data;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReflectionIT.Mvc.Paging;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolesManagerController : Controller
    {
        //private readonly RoleManager<IdentityRole> _roleManager;  //Before change IdentityRole and Create Class ApplicationRole

        //private readonly RoleManager<ApplicationRole> _roleManager;   //Before add and change   ApplicationeRoleManager (IApplicationRoleManager)

        //public RolesManagerController(RoleManager<ApplicationRole> roleManager)
        //{
        //    _roleManager = roleManager;
        //}



        private readonly IApplicationRoleManager _roleManager;
        public RolesManagerController(IApplicationRoleManager roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index(int page=1,int  row =10)
        {
            // var Roles = _roleManager.Roles.Select(r => new RolesViewModel { RoleID = r.Id, RoleName = r.Name ,Description = r.Description }).ToList();

            var Roles = _roleManager.GetAllRolesAndUsersCount();
            var PagingModel = PagingList.Create(Roles, row, page);
            PagingModel.RouteValue = new Microsoft.AspNetCore.Routing.RouteValueDictionary
            {
                {"row" , row }
            };
            return View(PagingModel);
        }

        [HttpGet]
        public  IActionResult AddRole()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRole(RolesViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _roleManager.RoleExistsAsync(viewModel.RoleName))
                {
                    ViewBag.Error = "خطا!!! این نقش تکراری است";
                }
                else
                {
                    var result = await _roleManager.CreateAsync(new ApplicationRole(viewModel.RoleName, viewModel.Description));
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    ViewBag.Error = "در ذخیره اطلاعات خطایی رخ داده است";
                    //return View(viewModel);
                }
            
            }

            return View(viewModel);
        }




        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Role = await _roleManager.FindByIdAsync(id);
            if (Role == null)
            {
                return NotFound();
            }

            RolesViewModel RoleVM = new RolesViewModel
            {
                RoleID = Role.Id,
                RoleName = Role.Name,
                Description = Role.Description,
                RecentRoleName = Role.Name         //  save In Edit when  rOLE nAME Repeat but change Edit Descriptin.
                


            };
            return View(RoleVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRole(RolesViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var Role = await _roleManager.FindByIdAsync(viewModel.RoleID);
                if (Role == null)
                {
                    return NotFound();
                }

                if (await _roleManager.RoleExistsAsync(viewModel.RoleName) && viewModel.RecentRoleName != viewModel.RoleName)
                {
                    ViewBag.Error = "خطا این نقش تکراری است";
                }
                else
                {

                    Role.Name = viewModel.RoleName;
                    Role.Description = viewModel.Description;

                    var result = await _roleManager.UpdateAsync(Role);
                    if (result.Succeeded)
                    {
                        ////ViewBag.Message = "alert-success";
                        //// return View(viewModel);
                        //return RedirectToAction("Index");

                        ViewBag.Success = "ذخیره تغییرات با موفقیت انجام شد";


                    }
                    else
                    {
                        ViewBag.Error = "خطا!!! در ذخیره تغییرات خطایی رخ داده است";
                    }
                    ViewBag.Message = "alert-danger";
                    return View(viewModel);
                }





            }

           
           
            return View(viewModel);
        }

        [HttpGet]
        public  async Task<IActionResult> DeleteRole(string id)
        {
            if (id == null)
            {
                return NotFound()
                    ;
            }
            var Role = await _roleManager.FindByIdAsync(id);
            if (Role== null)
            {
                return NotFound();
            }

            RolesViewModel ViewModel = new RolesViewModel
            {
                RoleID = Role.Id,
                RoleName = Role.Name,
            };

            return View(ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("DeleteRole")]
        public async Task<IActionResult> DeletedRole(string id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var Role = await _roleManager.FindByIdAsync(id);
            if (Role == null)
            {
                return NotFound();
            }

            var result = await _roleManager.DeleteAsync(Role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = "در حذف اطلاعات خطایی رخ داده است";

            RolesViewModel viewModel = new RolesViewModel
            {
                RoleID = Role.Id,
                RoleName = Role.Name,
            };

            return View(viewModel); 

        }


    }
}