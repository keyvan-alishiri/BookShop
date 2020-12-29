using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using ReflectionIT.Mvc.Paging;

namespace BookShop.Areas.Admin.Controllers
{
    public class UsersManagerController : Controller
    {
        private readonly IApplicationUserManager _userManager;
        public UsersManagerController(IApplicationUserManager userMnager)
        {
            _userManager = userMnager;
        }




        [Area("Admin")]
        public async Task<IActionResult>  Index(string Msg, int page = 1,int row =10)
        {
            if(Msg== "Succese")
            {
                ViewBag.Alert = "عضویت با موفقیت انجام شد.";
            }

            var PagingModel = PagingList.Create(await _userManager.GetAllUsersWithRolesAsync(), row, page);



            return View(PagingModel);
        }
    }
}