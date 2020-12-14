using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProvincesController : Controller
    {

        private readonly BookShopContext _context;

        public ProvincesController(BookShopContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Provices.AsNoTracking().ToListAsync());
        }
    }
}
