using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Areas.Api.Classes;
using BookShop.Models;
using BookShop.Models.UnitOfWork;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Api.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiResultFilter]
    [ApiVersion("1.0")]
    public class BooksApiController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BooksApiController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //[HttpGet]
        //public List<BookIndexViewModel> GetBooks()
        //{
        //    return _unitOfWork.bookRepository.GetAllBooks("", "", "", "", "", "", "");
        //}


        /// <summary>
        /// Before change ApiResult (Add ApiResult - assert - enumExtentions - ApiResultStatusCode)
        /// </summary>
        /// <param name="ViewModel"></param>
        /// <returns></returns>
        //[HttpGet]
        //public ApiResult GetBooks()
        //{
        //    return new ApiResult
        //    {
        //        IsSuccess = true,
        //        Message = new List<string> { "عملیات با موفقیت انجام شد" },
        //        Data = _unitOfWork.bookRepository.GetAllBooks("", "", "", "", "", "", "")
        //    };
        //}

            [HttpGet]
        public ApiResult<List<BookIndexViewModel>> GetBooks()
        {
            // return _unitOfWork.bookRepository.GetAllBooks("", "", "", "", "", "", "");
            return Ok(_unitOfWork.bookRepository.GetAllBooks("", "", "", "", "", "", ""));

        }


        [HttpPost]
        public async Task<ApiResult> CreateBook(BooksCreateEditViewModel ViewModel)
        {
            if (await _unitOfWork.bookRepository.CreateBookAsync(ViewModel))
            {

                return Ok();
            }

            else
            {

                return BadRequest("در انجام عملیات خطایی رخ داده است");
            }


        }

        [HttpPut]
        public async Task<ApiResult> EditBookAsync(BooksCreateEditViewModel ViewModel)
        {
            if (await _unitOfWork.bookRepository.EditBookAsync(ViewModel))

                return Ok();
            else

                return BadRequest("در انجام عملیات خطایی زخ داده است");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var Book = await _unitOfWork.BaseRepository<Book>().FindByIDAsync(id);
            if (Book != null)
            {
                Book.Delete = true;
                await _unitOfWork.Commit();
                // return Content("حذف کتاب با موفقیت انجام شد.");
                return Ok();
            }

            else
            {
                return NotFound();
            }
        }



    }
}