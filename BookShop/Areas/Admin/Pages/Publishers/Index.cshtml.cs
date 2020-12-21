using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;
using BookShop.Models.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookShop.Areas.Admin.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 3;
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages; 
        public IEnumerable<Publisher> publishers { get; set; }
        public async Task<IActionResult>  OnGet()
        {
            Count = _unitOfWork.BaseRepository<Publisher>().GetCount();

            publishers = await _unitOfWork.BaseRepository<Publisher>().GetPaginateResultAsync(CurrentPage, PageSize);
            return Page();
        }

       

        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            else
            {
                var publisher = await _unitOfWork.BaseRepository<Publisher>().FindByIDAsync(id);
                if (publisher == null)
                {
                    return NotFound();
                }
                else
                {
                    _unitOfWork.BaseRepository<Publisher>().Delete(publisher);
                    await _unitOfWork.Commit();
                   return RedirectToPage("./Index");
                }
            }
        }


    }
}