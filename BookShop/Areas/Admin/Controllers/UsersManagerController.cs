using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Admin.Controllers
{
    public class UsersManagerController : Controller
    {
        [Area("Admin")]
        public IActionResult Index(string Msg)
        {
            if(Msg== "Succese")
            {
                ViewBag.Alert = "عضویت با موفقیت انجام شد.";
            }
            return View();
        }
    }
}