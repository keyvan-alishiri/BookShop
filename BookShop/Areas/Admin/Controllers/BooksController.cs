using BookShop.Areas.Admin.Data;
using BookShop.Classes;
using BookShop.Models;
using BookShop.Models.Repository;
using BookShop.Models.UnitOfWork;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    [DisplayName("مدیریت کتاب ها")]
    public class BooksController : Controller
    {
        //private readonly BookShopContext _context;
        private readonly IUnitOfWork _unitofwork;
        private readonly IHostingEnvironment _environment;
        //private readonly BooksRepository _repository;    Placed into Interface UnitOfWork







        //public BooksController(BookShopContext context, BooksRepository repository)
        //{
        //    _context = context;
        //    _repository = repository;
        //}

        public BooksController(IUnitOfWork unitOfWork , IHostingEnvironment environment)
        {
            _unitofwork = unitOfWork;
            _environment = environment;
           
        }
        public IActionResult AdvancedSearch(BooksAdvancedSearch viewModel)
        {
            viewModel.Title = string.IsNullOrEmpty(viewModel.Title) ? "" : viewModel.Title;
            viewModel.ISBN = string.IsNullOrEmpty(viewModel.ISBN) ? "" : viewModel.ISBN;
            viewModel.Language = string.IsNullOrEmpty(viewModel.Language) ? "" : viewModel.Language;
            viewModel.Publisher = string.IsNullOrEmpty(viewModel.Publisher) ? "" : viewModel.Publisher;
            viewModel.Author = string.IsNullOrEmpty(viewModel.Author) ? "" : viewModel.Author;
            viewModel.Translator = string.IsNullOrEmpty(viewModel.Translator) ? "" : viewModel.Translator;
            viewModel.Category = string.IsNullOrEmpty(viewModel.Category) ? "" : viewModel.Category;

         //   var Books = _repository.GetAllBooks(viewModel.Title, viewModel.ISBN, viewModel.Language, viewModel.Publisher, viewModel.Author, viewModel.Translator, viewModel.Category);
            var Books = _unitofwork.BooksRepository.GetAllBooks(viewModel.Title, viewModel.ISBN, viewModel.Language, viewModel.Publisher, viewModel.Author, viewModel.Translator, viewModel.Category);

            return View(Books);
        }

        [Authorize(Policy =ConstantPolicies.DynamicPermission)]
        [DisplayName("مشاهده کتاب ها")]
        public IActionResult Index(string Msg, int page = 1, int row = 5, string SortExpression = "Title", string title = "")
        {

            title = string.IsNullOrEmpty(title) ? "" : title;
            if (Msg != null)
            {
                ViewBag.Msg = "در ثبت اطلاعات خطایی رخ داده است";
            }
            List<int> Rows = new List<int>
            {
                1,2,5,10,15,20,50,100
            };
            ViewBag.NumOfRow = (page - 1) * row + 1;
            ViewBag.RowID = new SelectList(Rows, row);
            ViewBag.Search = title;

            //var PagingModel = PagingList.Create(_repository.GetAllBooks(title, "", "", "", "", "", ""), row, page, SortExpression, "Title");
            var PagingModel = PagingList.Create(_unitofwork.BooksRepository.GetAllBooks(title, "", "", "", "", "", ""), row, page, SortExpression, "Title");



            PagingModel.RouteValue = new RouteValueDictionary
            {
                { "row",row},
                {"title",title }
            };

            //ViewBag.Categories = _repository.GetAllCategories();
            //ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageName", "LanguageName");
            //ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherName", "PublisherName");
            //ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "NameFamily", "NameFamily");
            //ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "NameFamily", "NameFamily");

            ///////////////////////////UnitOfWork//////////////////////
            //ViewBag.Categories = _repository.GetAllCategories();
            ViewBag.Categories = _unitofwork.BooksRepository.GetAllCategories();
            ViewBag.LanguageID = new SelectList(_unitofwork.BaseRepository<Language>().FindAll(), "LanguageName", "LanguageName");
            ViewBag.PublisherID = new SelectList(_unitofwork.BaseRepository<Publisher>().FindAll(), "PublisherName", "PublisherName");
            ViewBag.AuthorID = new SelectList(_unitofwork.BaseRepository<Author>().FindAll().Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "NameFamily", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_unitofwork.BaseRepository<Translator>().FindAll().Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "NameFamily", "NameFamily");
            return View(PagingModel);
        }

        [Authorize(Policy = ConstantPolicies.DynamicPermission)]
        [DisplayName("افزودن کتاب جدید")]
        public IActionResult Create()
        {
            //ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
            //ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherID", "PublisherName");
            //ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
            //ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");


            /////////////////////////////////UnitOfWork///////////////////////////////   
            ViewBag.LanguageID = new SelectList(_unitofwork.BaseRepository<Language>().FindAll(), "LanguageID", "LanguageName");
            ViewBag.PublisherID = new SelectList(_unitofwork.BaseRepository<Publisher>().FindAll(), "PublisherID", "PublisherName");
            ViewBag.AuthorID = new SelectList(_unitofwork.BaseRepository<Author>().FindAll().Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_unitofwork.BaseRepository<Translator>().FindAll().Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");

            //BooksSubcategoriesViewModel SubCategoriesVM = new BooksSubcategoriesViewModel(_repository.GetAllCategories(), null);
            BooksSubcategoriesViewModel SubCategoriesVM = new BooksSubcategoriesViewModel(_unitofwork.BooksRepository.GetAllCategories(), null);
            BooksCreateEditViewModel ViewModel = new BooksCreateEditViewModel(SubCategoriesVM);
            return View(ViewModel);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BooksCreateEditViewModel ViewModel)
        {
            if (ModelState.IsValid)
            {
               


                UploadFileResult result = new UploadFileResult();
                string NewFileName = null;
                if (ViewModel.File != null)
                {
                    NewFileName = _unitofwork.BooksRepository.CheckFileName(ViewModel.File.FileName);
                    var path = $"{_environment.WebRootPath}/BookFiles/{NewFileName}";
                    result = await _unitofwork.BooksRepository.UploadFileAsync(ViewModel.File, path);
                }

                if (result.IsSuccess == true || result.IsSuccess == null)
                {
                    ViewModel.FileName = NewFileName;
                    if (await _unitofwork.BooksRepository.CreateBookAsync(ViewModel))
                        return RedirectToAction("Index");
                    else
                        ViewBag.Error = "در انجام عملیات خطایی رخ داده است.";
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item);
                    }
                }
            }

            ViewBag.LanguageID = new SelectList(_unitofwork.BaseRepository<Language>().FindAll(), "LanguageID", "LanguageName");
            ViewBag.PublisherID = new SelectList(_unitofwork.BaseRepository<Publisher>().FindAll(), "PublisherID", "PublisherName");
            ViewBag.AuthorID = new SelectList(_unitofwork.BaseRepository<Author>().FindAll().Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_unitofwork.BaseRepository<Translator>().FindAll().Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");

            //ViewModel.SubCategoriesVM = new BooksSubcategoriesViewModel(_repository.GetAllCategories(), ViewModel.CategoryID);
            ViewModel.SubCategoriesVM = new BooksSubcategoriesViewModel(_unitofwork.BooksRepository.GetAllCategories(), ViewModel.CategoryID);
            return View(ViewModel);

        }


        [Authorize(Policy = ConstantPolicies.DynamicPermission)]
        [DisplayName("مشاهده جزییات کتاب")]
        public IActionResult Details(int id)
        {
            //var BookInfo = _context.ReadAllBooks.Where(b => b.BookID == id).First();

            //استفاده به دو شکل query type و متدfromsql
            //var BookInfo = _context.ReadAllBooks.FromSql("SELECT b.BookID, b.ISBN, b.Image, b.IsPublish, b.NumOfPages, b.Price, b.PublishDate, b.PublishYear, b.Stock, b.Summary, b.Title, b.Weight, l.LanguageName, p.PublisherName, dbo.GetAllAuthor(b.BookID) AS Authors, dbo.GetAllTranslators(b.BookID) AS Translators, dbo.GetAllCategories(b.BookID) AS Categories FROM  dbo.BookInfo AS b INNER JOIN dbo.Languages AS l ON b.LanguageID = l.LanguageID INNER JOIN dbo.Publishers AS p ON b.PublisherID = p.PublisherID WHERE(b.[Delete] = 0)")
            //    .Where(b => b.BookID == id).First();


           

            //شکل دیگر استفاده از quey type ها  با استفاده از تعریف در متد OnModelCreate
            //  var BookInfo = _context.Query<ReadAllBooks>().Where(b => b.BookID == id).First();




            //////////////////////////////////////////////// استفاده از UnitOfWork /////////////////////////////////
              var BookInfo = _unitofwork._Context.ReadAllBooks.Where(b => b.BookID == id).First();
            // return View(BookInfo); Before Add Ajax
            return PartialView(BookInfo);
        }

        [Authorize(Policy = ConstantPolicies.DynamicPermission)]
        [DisplayName(" حذف کتاب")]

        public async Task<IActionResult> Delete(int id)
        {
            //var Book = _context.Books.Find(id);

            /////////////////////////////////////UnitOfWork////////////////////////////
            var Book = await _unitofwork.BaseRepository<Book>().FindByIDAsync(id);
            if (Book != null)
            {
                Book.Delete = true;
                var path = $"{_environment.WebRootPath}/BookFiles/{Book.File}";
                if(System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                    Book.File = null;
                }



                //Book.Title = ""; //میتوان با این روش نیز اطلاعات دیتابیس را آپدیت نمود
                /*await _context.SaveChangesAsync();*/ //قبل از اضافه نمودن uNITpFwORK


                ////////////////  UNIT OF WORK ///////////////
              await  _unitofwork.Commit();

                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }


        }


        [HttpGet]
        [Authorize(Policy = ConstantPolicies.DynamicPermission)]
        [DisplayName("ویرایش اطلاعات کتاب ")]

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                //var Book = _context.Books.FindAsync(id);

                ///////////////////////    unit of work       ////////////////
                var Book = _unitofwork.BaseRepository<Book>().FindByIDAsync(id);
                if (Book == null)
                {
                    return NotFound();
                }
                else
                {
                    //var viewmodel = (from b in _context.Books.Include(l => l.Language).Include(p => p.Publisher)
                    //                 where (b.BookID == id)
                    //                 select new BooksCreateEditViewModel
                    //                 {
                    //                     BookID = b.BookID,
                    //                     ISBN = b.ISBN,
                    //                     Title = b.Title,
                    //                     NumOfPages = b.NumOfPages,
                    //                     Price = b.Price,
                    //                     Stock = b.Stock,
                    //                     IsPublish = (bool)b.IsPublish,
                    //                     LanguageID = b.LanguageID,
                    //                     PublisherID = b.PublisherID,
                    //                     PublishYear = b.PublishYear,
                    //                     Summary = b.Summary,
                    //                     Weight = b.Weight,
                    //                     RecentIsPublish = (bool)b.IsPublish,
                    //                     PublishDate = b.PublishDate,

                    //                 }).FirstAsync();

                    //////////////////////////////// unit of work //////////////////////////////////////
                    var viewmodel = (from b in _unitofwork._Context.Books.Include(l => l.Language).Include(p => p.Publisher)
                                     where (b.BookID == id)
                                     select new BooksCreateEditViewModel
                                     {
                                         BookID = b.BookID,
                                         ISBN = b.ISBN,
                                         Title = b.Title,
                                         NumOfPages = b.NumOfPages,
                                         Price = b.Price,
                                         Stock = b.Stock,
                                         IsPublish = (bool)b.IsPublish,
                                         LanguageID = b.LanguageID,
                                         PublisherID = b.PublisherID,
                                         PublishYear = b.PublishYear,
                                         Summary = b.Summary,
                                         Weight = b.Weight,
                                     
                                         PublishDate = b.PublishDate,
                                         ImageByte =b.Image,
                                        FileName = b.File,

                                     }).FirstAsync();




                    int[] AuthorsArray = await (from a in _unitofwork._Context.Author_Books
                                                where (a.BookID == id)
                                                select a.AuthorID).ToArrayAsync();

                    int[] TranslatorArray = await (from t in _unitofwork._Context.Book_Translators
                                                   where (t.BookID == id)
                                                   select t.TranslatorID).ToArrayAsync();
                    int[] CategoriesArray = await (from c in _unitofwork._Context.Book_Categories
                                                   where (c.BookID == id)
                                                   select c.CategoryID).ToArrayAsync();

                    viewmodel.Result.AuthorID = AuthorsArray;
                    viewmodel.Result.TranslatorID = TranslatorArray;
                    viewmodel.Result.CategoryID = CategoriesArray;



                    //ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
                    //ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherID", "PublisherName");
                    //ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
                    //ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");
                    //viewmodel.Result.Categories = _repository.GetAllCategories();  //remove after change BooksViewModel in video 83



                    ////////////////////////////////// unit of work /////////////////////////////////////////
                    ViewBag.LanguageID = new SelectList(_unitofwork.BaseRepository<Language>().FindAll()  , "LanguageID", "LanguageName");
                    ViewBag.PublisherID = new SelectList(_unitofwork.BaseRepository<Publisher>().FindAll(), "PublisherID", "PublisherName");
                    ViewBag.AuthorID = new SelectList(_unitofwork.BaseRepository<Author>().FindAll().Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
                    ViewBag.TranslatorID = new SelectList(_unitofwork.BaseRepository<Translator>().FindAll().Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");

                    //viewmodel.Result.SubCategoriesVM = new BooksSubcategoriesViewModel(_repository.GetAllCategories(), CategoriesArray);

                    viewmodel.Result.SubCategoriesVM = new BooksSubcategoriesViewModel(_unitofwork.BooksRepository.GetAllCategories(), CategoriesArray);



                    return View(await viewmodel);

                }
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BooksCreateEditViewModel viewModel)
        {


           

            //ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
            //ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherID", "PublisherName");
            //ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
            //ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");

            ViewBag.LanguageID = new SelectList(_unitofwork.BaseRepository<Language>().FindAll(), "LanguageID", "LanguageName");
            ViewBag.PublisherID = new SelectList(_unitofwork.BaseRepository<Publisher>().FindAll(), "PublisherID", "PublisherName");
            ViewBag.AuthorID = new SelectList(_unitofwork.BaseRepository<Author>().FindAll().Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_unitofwork.BaseRepository<Translator>().FindAll().Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");

            //viewModel.SubCategoriesVM = new BooksSubcategoriesViewModel(_repository.GetAllCategories(), viewModel.CategoryID);
            viewModel.SubCategoriesVM = new BooksSubcategoriesViewModel(_unitofwork.BooksRepository.GetAllCategories(), viewModel.CategoryID);



            if (ModelState.IsValid)
            {
                UploadFileResult result = new UploadFileResult();
                string NewFileName = viewModel.FileName;
                string path;
                if (viewModel.File != null)
                {
                    NewFileName = _unitofwork.BooksRepository.CheckFileName(viewModel.File.FileName);
                    path = $"{_environment.WebRootPath}/BookFiles/{NewFileName}";
                    result = await _unitofwork.BooksRepository.UploadFileAsync(viewModel.File, path);
                }

                if (result.IsSuccess == true || result.IsSuccess == null)
                {
                    if (result.IsSuccess == true)
                    {
                        path = $"{_environment.WebRootPath}/BookFiles/{viewModel.FileName}";
                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }
                    }

                    viewModel.FileName = NewFileName;
                    var operationResult = await _unitofwork.BooksRepository.EditBookAsync(viewModel);
                    if (operationResult.IsSuccess == true)
                    {
                        ViewBag.MsgSuccess = "ذخیره تغییرات با موفقیت انجام شد.";
                        return View(viewModel);
                    }
                    else
                    {
                        foreach (var item in operationResult.Errors)
                            ModelState.AddModelError("", item);
                        return View(viewModel);
                    }
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item);
                    }

                    return View(viewModel);
                }

            }

            else
            {
                ViewBag.MsgFailed = "اطلاعات فرم نامعتبر است.";
                return View(viewModel);
            }
        }


        public async Task<IActionResult> SearchByISBN(string ISBN)
        {
            if (ISBN != null)
            {
                //////////////////////     In the unit of work it becomes _unitofwork._Context instead of context
                var Book = (from b in _unitofwork._Context.Books
                    where (b.ISBN == ISBN)
                    select new BookIndexViewModel()
                    {
                        Title = b.Title,
                        Author = BookShopContext.GetAllAuthors(b.BookID),
                        Translator = BookShopContext.GetAllTranslators(b.BookID),
                        Category = BookShopContext.GetAllCategories(b.BookID)

                    }).FirstOrDefaultAsync();

                if (Book.Result == null)
                {
                    ViewBag.Msg = "کتابی با این شابک پیدا نشد.";
                }



                return View(await Book);
            }
            else
            {
                return View();
            }
           
        }

       public async Task<IActionResult>  Download(int id)
        {
            var book =await _unitofwork.BaseRepository<Book>().FindByIDAsync(id);
           
            if (book == null)
                return NotFound();
            var Path = $"{_environment.WebRootPath}/BookFiles/{book.File}";
            var memory = new MemoryStream();
            using (var stream = new FileStream(Path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, FileExtentions.GetContentType(Path), book.File);
        }


        public async Task<IActionResult> ViewImage(int id)
        {
            var Book = await _unitofwork.BaseRepository<Book>().FindByIDAsync(id);
            if (Book == null)
                return NotFound();
            var memoryStream = new MemoryStream(Book.Image);
            return new FileStreamResult(memoryStream, "image/png");
        }

      


        [HttpGet]
        public IActionResult InsertOrUpdateBookImage(int id)
        {
            var Book = _unitofwork._Context.Books.Where(b => b.BookID == id).Select(b => new ImageBookViewModel { BookID = b.BookID, ImageByte = b.Image }).FirstOrDefault();
            if (Book == null)
                ModelState.AddModelError("", "کتاب با این مشخصات یافت نشد.");

            return PartialView("_InsertOrUpdateBookImage", Book);
        }

        [HttpPost]
        public async Task<IActionResult> InsertOrUpdateBookImage(ImageBookViewModel ViewModel)
        {
            if (ModelState.IsValid)
            {
                var Book = await _unitofwork.BaseRepository<Book>().FindByIDAsync(ViewModel.BookID);
                using (var memorySteam = new MemoryStream())
                {
                    string FileExtension = Path.GetExtension(ViewModel.Image.FileName);
                    await ViewModel.Image.CopyToAsync(memorySteam);
                    var types = FileExtentions.FileType.Image;
                    bool result = FileExtentions.IsValidFile(memorySteam.ToArray(), types, FileExtension.Replace('.', ' '));
                    if (result)
                    {
                        Book.Image = memorySteam.ToArray();
                        await _unitofwork.Commit();
                        ViewModel.ImageByte = memorySteam.ToArray();
                        TempData["Notifications"] = "آپلود فایل با موفقیت انجام شد.";
                    }
                    else
                        ModelState.AddModelError("", "فایل تصویر کتاب نامعتبر است.");
                }
            }
            return PartialView("_InsertOrUpdateBookImage", ViewModel);
        }

    }
}