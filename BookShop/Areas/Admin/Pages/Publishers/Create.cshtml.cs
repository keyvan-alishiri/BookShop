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
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public Publisher Publisher { get; set; }
        public CreateModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            await _unitOfWork.BaseRepository<Publisher>().CreateAsync(Publisher);
            await _unitOfWork.Commit();
            return RedirectToPage("./Index");
          
        }
    }
}