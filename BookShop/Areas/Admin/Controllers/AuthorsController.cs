using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookShop.Models;
using BookShop.Models.UnitOfWork;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ReflectionIT.Mvc.Paging;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorsController : Controller
    {
        private readonly    IUnitOfWork _unitOfWork;
        //private readonly BookShopContext _context;
        private readonly string NotFoundAuthor = "نویسنده ای با این مشخصات یافت نشد.";
        public AuthorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Admin/Authors
        public async Task<IActionResult> Index(int page = 1, int row =10)
        {
            // ViewBag.EntityStates = DisplayState(_context.ChangeTracker.Entries());
            var Authors = _unitOfWork.BaseRepository<Author>().FindAllAsync();
            var PagingModel = PagingList.Create(await Authors, row, page);
            PagingModel.RouteValue = new Microsoft.AspNetCore.Routing.RouteValueDictionary
            {
                {"row" , row },
            };

            var isAjax = Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            if (isAjax)
                return PartialView("_AuthorsTable", PagingModel);

            return View("Index", PagingModel);
        }

        // GET: Admin/Authors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var author = await _context.Authors
            //    .FirstOrDefaultAsync(m => m.AuthorID == id);


            var author = await _unitOfWork.BaseRepository<Author>().FindByIDAsync(id);


            if (author == null)
            {
                return NotFound();
            }


           

            return View(author);
        }

        // GET: Admin/Authors/Create
        public IActionResult Create()
        {
            // var DisconnectedEntity = new Author() { FirstName = "Keyvan", LastName = "Alishiri", AuthorID = 3 };
            //  var EntityState = _context.Entry(DisconnectedEntity).State;

            return PartialView("_Create");
        }

        // POST: Admin/Authors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuthorID,FirstName,LastName")] Author author)
        {
            if (ModelState.IsValid)
            {
               
                //_context.Add(author);
                //_context.Update(author).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                //_context.Entry(author).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                //var EntityState = DisplayState(_context.ChangeTracker.Entries());
                // await _context.SaveChangesAsync();
                await  _unitOfWork.BaseRepository<Author>().CreateAsync(author);
                await _unitOfWork.Commit();
                TempData["notification"] = "درج اطلاعات با موفقست انجام شد.";
               
               // return RedirectToAction(nameof(Index));
            }

            //return View(author);
            return PartialView("_Create", author);
        }

        
















        // GET: Admin/Authors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                //return NotFound();
                ModelState.AddModelError(string.Empty, NotFoundAuthor);
            }

            //var author = await _context.Authors.FindAsync(id);

            var author = await _unitOfWork.BaseRepository<Author>().FindByIDAsync(id);

            if (author == null)
            {
                //return NotFound();
                ModelState.AddModelError(string.Empty, NotFoundAuthor);
            }
            return PartialView("_Edit",author);
            //return View(author);
        }

        // POST: Admin/Authors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuthorID,FirstName,LastName")] Author author)
        {
            if (id != author.AuthorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    //_context.Update(author);
                    //  _context.Attach(author).State=EntityState.Modified;



                    //_context.Entry(author).State = EntityState.Modified;
                    // var EntityStates = DisplayState(_context.ChangeTracker.Entries());
                    //await _context.SaveChangesAsync();

                    _unitOfWork.BaseRepository<Author>().Update(author);
                   await _unitOfWork.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!AuthorExists(author.AuthorID))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}


                    /////////////////UnitOfWork////////////////////////////////
                    if (await _unitOfWork.BaseRepository<Author>().FindByIDAsync(author.AuthorID) == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }








                }
                // return RedirectToAction(nameof(Index));
                TempData["notification"] = "ویرایش اطلاعات با موفقیت انجام شد.";
            }
            // return View(author);
            return PartialView("_Edit", author);
        }

        // GET: Admin/Authors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var author = await _context.Authors
            //    .FirstOrDefaultAsync(m => m.AuthorID == id);


            var author = await _unitOfWork.BaseRepository<Author>().FindByIDAsync(id);


            if (author == null)
            {
                return NotFound();
            }

            // return View(author);
            return PartialView("_Delete",author);
        }

        // POST: Admin/Authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var author = await _context.Authors.FindAsync(id);


            //_context.Authors.Remove(author);

            //_context.Attach(author).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            //var EntityState = DisplayState(_context.ChangeTracker.Entries());
            //await _context.SaveChangesAsync();
            var author = await _unitOfWork.BaseRepository<Author>().FindByIDAsync(id);
            if(author == null)
            {
                return NotFound();
            }
            else
            {
                _unitOfWork.BaseRepository<Author>().Delete(author);
                await _unitOfWork.Commit();
                TempData["notification"] = "حذف اطلاعات با موفقیت انجام شد.";
            }

            //return RedirectToAction(nameof(Index));
            return PartialView("_Delete", author);
        }

        //private bool AuthorExists(int id)
        //{
        //    return _context.Authors.Any(e => e.AuthorID == id);
        //}



        private List<EntityStates> DisplayState(IEnumerable<EntityEntry> entities)
        {
            List<EntityStates> EntityStates = new List<EntityStates>();
            foreach (var entry in entities)
            {
                EntityStates state = new EntityStates()

                {
                    EntityName = entry.Entity.GetType().Name,
                    EntityState = entry.State.ToString(),



                };

                EntityStates.Add(state);
            }


            return EntityStates;

        }


        public async Task<IActionResult> AuthorBooks(int id)
        {
            ////Lazy Loading
            //var Author = _context.Authors.Where(a => a.AuthorID == id).FirstOrDefaultAsync();


            //UnitOfWork
            var Author = _unitOfWork.BaseRepository<Author>().FindByIDAsync(id);

            if (Author == null)
            {
                return NotFound();
            }
            else
            {
                return View(await Author);
            }
            
        }

        public IActionResult Notification()
        {

            
            return PartialView("_Notification" , TempData["notification"]);
        }


        
    }
















    
}
