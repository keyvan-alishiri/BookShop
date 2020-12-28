using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using BookShop.Models.UnitOfWork;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CitiesController : Controller
    {
        //private readonly BookShopContext _context;
        private readonly IUnitOfWork _unitOfwork;
        //public CitiesController(BookShopContext context)
        //{
        //    _context = context;
        //}

        public CitiesController(IUnitOfWork unitOfWork)
        {
            _unitOfwork = unitOfWork;
        }

        public async Task<IActionResult> Index(int id, int page = 1, int row = 10) // id==> ProvinceID


        {
           if (id == 0)
            {

                return NotFound();
            }
            else
            {
                // Explicit Loading
                var Province =_unitOfwork._Context.Provices.SingleAsync(p => p.ProvinceID == id);
                _unitOfwork._Context.Entry(await Province).Collection(c => c.City).Load();

                //query filter
                //_context.Entry(await Province).Collection(c => c.City).Query().Where(c=>c.CityName.Contains("ف")).Load();

                //var book = _context.Books.Where(b => b.BookID == 2).First();
                //_context.Entry(book).Reference(l=>l.Language).Load();
                return View(Province.Result);
            }
          
        }

        public async Task<IActionResult> Create(int id)
        {
            City city =  new City() { ProvinceID = id };
             return   View(city);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CityID,CityName,ProvinceID")] City city)
        {
            if (ModelState.IsValid)
            {
                Random rdm = new Random();
                int RandomID = rdm.Next(400, 1000);
                var ExitID = await _unitOfwork.BaseRepository<City>().FindByIDAsync(RandomID);
                while (ExitID != null)
                {
                    RandomID = rdm.Next(400, 1000);
                    ExitID = await _unitOfwork.BaseRepository<City>().FindByIDAsync(RandomID);
                }

                City City = new City() { CityID = RandomID, CityName = city.CityName, ProvinceID = city.ProvinceID };
                await _unitOfwork.BaseRepository<City>().CreateAsync(City);
                await _unitOfwork.Commit();
                return RedirectToAction(nameof(Index), new { id = city.ProvinceID });
            }
            return View(city);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _unitOfwork.BaseRepository<City>().FindByIDAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CityID,CityName,ProvinceID")] City city)
        {
            if (id != city.CityID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfwork.BaseRepository<City>().Update(city);
                    await _unitOfwork.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await _unitOfwork.BaseRepository<Provice>().FindByIDAsync(city.CityID) == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = city.ProvinceID });
            }
            return View(city);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _unitOfwork.BaseRepository<City>().FindByIDAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var City = await _unitOfwork.BaseRepository<City>().FindByIDAsync(id);
            if (City == null)
            {
                return NotFound();
            }

            else
            {
                _unitOfwork.BaseRepository<City>().Delete(City);
                await _unitOfwork.Commit();
                return RedirectToAction(nameof(Index), new { id = City.ProvinceID });
            }
        }










    }
}
