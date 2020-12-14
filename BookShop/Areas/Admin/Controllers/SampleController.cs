using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SampleController : Controller
    {
        private readonly BookShopContext _context;

        public SampleController(BookShopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Stopwatch  sw = new Stopwatch();
            sw.Start();

            //var query = EF.CompileAsyncQuery((BookShopContext contex, int id)

            //    => contex.Books.SingleOrDefault(b => b.BookID == id)

            //);




            for (int i = 0; i < 1000; i++)
            {
                var Book = _context.Books.SingleOrDefault(b => b.BookID == i);
                //var Book = query(_context, i);
            }

            sw.Stop();

            return View(sw.Elapsed.Milliseconds);
        }
    }
}
