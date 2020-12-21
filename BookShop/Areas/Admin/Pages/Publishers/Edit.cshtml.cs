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
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public Publisher publisher { get; set; }
        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var isExitPublisher = await _unitOfWork.BaseRepository<Publisher>().FindByIDAsync(id);

            if (isExitPublisher != null)
            {
                publisher = await _unitOfWork.BaseRepository<Publisher>().FindByIDAsync(id);
                return Page();
            }
            else
            {
                return NotFound();
            }
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var Publishers = await _unitOfWork.BaseRepository<Publisher>().FindByIDAsync(publisher.PublisherID);
                if (Publishers != null)
                {
                    Publishers.PublisherName = publisher.PublisherName;
                    await _unitOfWork.Commit();
                    return RedirectToPage("./Index");
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}