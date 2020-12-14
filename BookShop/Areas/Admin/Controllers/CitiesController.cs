using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CitiesController : Controller
    {
        private readonly BookShopContext _context;

        public CitiesController(BookShopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id)
        {
           if (id == 0)
            {
                return NotFound();
            }
            else
            {
                var Province = _context.Provices.SingleAsync(p => p.ProvinceID == id);
                _context.Entry(await Province).Collection(c => c.City).Load();

                //query filter
                //_context.Entry(await Province).Collection(c => c.City).Query().Where(c=>c.CityName.Contains("ف")).Load();

                //var book = _context.Books.Where(b => b.BookID == 2).First();
                //_context.Entry(book).Reference(l=>l.Language).Load();
                return View(Province.Result);
            }
          
        }
    }
}
