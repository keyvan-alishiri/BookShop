using BookShop.Models;
using BookShop.Models.Repository;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly BookShopContext _context;
        private readonly BooksRepository _repository;
        public BooksController(BookShopContext context, BooksRepository repository)
        {
            _context = context;
            _repository = repository;
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
            var Books = _repository.GetAllBooks(viewModel.Title, viewModel.ISBN, viewModel.Language, viewModel.Publisher, viewModel.Author, viewModel.Translator, viewModel.Category);

            return View(Books);
        }
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

            var PagingModel = PagingList.Create(_repository.GetAllBooks(title, "", "", "", "", "", ""), row, page, SortExpression, "Title");
            PagingModel.RouteValue = new RouteValueDictionary
            {
                { "row",row},
                {"title",title }
            };

            ViewBag.Categories = _repository.GetAllCategories();
            ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageName", "LanguageName");
            ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherName", "PublisherName");
            ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "NameFamily", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "NameFamily", "NameFamily");

            return View(PagingModel);
        }


        public IActionResult Create()
        {
            ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
            ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherID", "PublisherName");
            ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");

            BooksSubcategoriesViewModel SubCategoriesVM = new BooksSubcategoriesViewModel(_repository.GetAllCategories(), null);
            BooksCreateEditViewModel ViewModel = new BooksCreateEditViewModel(SubCategoriesVM);
            return View(ViewModel);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BooksCreateEditViewModel ViewModel)
        {
            if (ModelState.IsValid)
            {
                //List<Author_Book> authors = new List<Author_Book>(); Use relative save date then remove
                List<Book_Translator> translators = new List<Book_Translator>();
                List<Book_Category> categories = new List<Book_Category>();
                DateTime? PublishDate = null;

                if (ViewModel.TranslatorID != null)
                {
                    translators = ViewModel.TranslatorID.Select(a => new Book_Translator { TranslatorID = a }).ToList();
                }

                if (ViewModel.CategoryID != null)
                {
                    ViewModel.CategoryID.Select(a => new Book_Category { CategoryID = a }).ToList();
                }








                if (ViewModel.IsPublish == true)
                {
                    PublishDate = DateTime.Now;
                }

                try
                {
                    Book book = new Book()
                    {
                        /*  Delete = false,   */// Add Setting explicit Values for generated properties and not use delete
                        ISBN = ViewModel.ISBN,
                        IsPublish = ViewModel.IsPublish,
                        NumOfPages = ViewModel.NumOfPages,
                        Stock = ViewModel.Stock,
                        Price = ViewModel.Price,
                        LanguageID = ViewModel.LanguageID,
                        Summary = ViewModel.Summary,
                        Title = ViewModel.Title,
                        PublishYear = ViewModel.PublishYear,
                        PublishDate = PublishDate, //Add function in OnModelCreating for insert Default Value  Into sql SERVER
                        Weight = ViewModel.Weight,
                        PublisherID = ViewModel.PublisherID,
                        Author_Books = ViewModel.AuthorID.Select(a => new Author_Book { AuthorID = a }).ToList(),  //Use Related Save Data
                        book_Tranlators = translators,
                        book_Categories = categories,
                    };

                    await _context.Books.AddAsync(book);
                    await _context.SaveChangesAsync();



                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    return RedirectToAction("Index", new { Msg = "Faild" });
                }

            }
            else
            {
                ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
                ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherID", "PublisherName");
                ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
                ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");
                ViewModel.Categories = _repository.GetAllCategories();
                return View(ViewModel);
            }
        }

        public IActionResult Details(int id)
        {
            //var BookInfo = _context.ReadAllBooks.Where(b => b.BookID == id).First();

            //استفاده به دو شکل query type و متدfromsql
            var BookInfo = _context.ReadAllBooks.FromSql("SELECT b.BookID, b.ISBN, b.Image, b.IsPublish, b.NumOfPages, b.Price, b.PublishDate, b.PublishYear, b.Stock, b.Summary, b.Title, b.Weight, l.LanguageName, p.PublisherName, dbo.GetAllAuthor(b.BookID) AS Authors, dbo.GetAllTranslators(b.BookID) AS Translators, dbo.GetAllCategories(b.BookID) AS Categories FROM  dbo.BookInfo AS b INNER JOIN dbo.Languages AS l ON b.LanguageID = l.LanguageID INNER JOIN dbo.Publishers AS p ON b.PublisherID = p.PublisherID WHERE(b.[Delete] = 0)")
                .Where(b => b.BookID == id).First();



            //شکل دیگر استفاده از quey type ها  با استفاده از تعریف در متد OnModelCreate
            //var BookInfo = _context.Query<ReadAllBooks>().Where(b => b.BookID == id).First();
            return View(BookInfo);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var Book = _context.Books.Find(id);
            if (Book != null)
            {
                Book.Delete = true;
                //Book.Title = ""; //میتوان با این روش نیز اطلاعات دیتابیس را آپدیت نمود
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }


        }


        [HttpGet]

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var Book = _context.Books.FindAsync(id);
                if (Book == null)
                {
                    return NotFound();
                }
                else
                {
                    var viewmodel = (from b in _context.Books.Include(l => l.Language).Include(p => p.Publisher)
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
                                         RecentIsPublish = (bool)b.IsPublish,
                                         PublishDate = b.PublishDate,

                                     }).FirstAsync();

                    int[] AuthorsArray = await (from a in _context.Author_Books
                                                where (a.BookID == id)
                                                select a.AuthorID).ToArrayAsync();

                    int[] TranslatorArray = await (from t in _context.Book_Translators
                                                   where (t.BookID == id)
                                                   select t.TranslatorID).ToArrayAsync();
                    int[] CategoriesArray = await (from c in _context.Book_Categories
                                                   where (c.BookID == id)
                                                   select c.CategoryID).ToArrayAsync();

                    viewmodel.Result.AuthorID = AuthorsArray;
                    viewmodel.Result.TranslatorID = TranslatorArray;
                    viewmodel.Result.CategoryID = CategoriesArray;



                    ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
                    ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherID", "PublisherName");
                    ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
                    ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");
                    //viewmodel.Result.Categories = _repository.GetAllCategories();  //remove after change BooksViewModel in video 83

                    viewmodel.Result.SubCategoriesVM = new BooksSubcategoriesViewModel(_repository.GetAllCategories(), CategoriesArray);





                    return View(await viewmodel);

                }
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BooksCreateEditViewModel viewModel)
        {


            ViewBag.LanguageID = new SelectList(_context.Languages, "LanguageID", "LanguageName");
            ViewBag.PublisherID = new SelectList(_context.Publishers, "PublisherID", "PublisherName");
            ViewBag.AuthorID = new SelectList(_context.Authors.Select(t => new AuthorList { AuthorID = t.AuthorID, NameFamily = t.FirstName + " " + t.LastName }), "AuthorID", "NameFamily");
            ViewBag.TranslatorID = new SelectList(_context.Translator.Select(t => new TranslatorList { TranslatorID = t.TranslatorID, NameFamily = t.Name + " " + t.Family }), "TranslatorID", "NameFamily");


            viewModel.SubCategoriesVM = new BooksSubcategoriesViewModel(_repository.GetAllCategories(), viewModel.CategoryID);



            if (ModelState.IsValid)
            {



                try
                {
                    DateTime? PublishDate;
                    if (viewModel.IsPublish == true && viewModel.RecentIsPublish == false)
                    {
                        PublishDate = DateTime.Now;

                    }
                    else if (viewModel.RecentIsPublish == true && viewModel.IsPublish == false)
                    {
                        PublishDate = null;
                    }
                    else
                    {
                        PublishDate = viewModel.PublishDate;
                    }

                    Book book = new Book()
                    {
                        BookID = viewModel.BookID,
                        ISBN = viewModel.ISBN,
                        Title = viewModel.Title,
                        NumOfPages = viewModel.NumOfPages,
                        Price = viewModel.Price,
                        Stock = viewModel.Stock,
                        IsPublish = (bool)viewModel.IsPublish,
                        LanguageID = viewModel.LanguageID,
                        PublisherID = viewModel.PublisherID,
                        PublishYear = viewModel.PublishYear,
                        Summary = viewModel.Summary,
                        Weight = viewModel.Weight,
                        Delete = false,
                        PublishDate = PublishDate,




                    };

                    _context.Update(book);

                    var RecentAuthors = (from a in _context.Author_Books
                                         where (a.BookID == viewModel.BookID)
                                         select a.AuthorID).ToArray();

                    var RecentTranslators = (from t in _context.Book_Translators
                                             where (t.BookID == viewModel.BookID)
                                             select t.TranslatorID).ToArray();


                    var RecentCategories = (from c in _context.Book_Categories
                                            where (c.BookID == viewModel.BookID)
                                            select c.CategoryID).ToArray();


                    var DeletedAuthors = RecentAuthors.Except(viewModel.AuthorID);

                    var DeletedTranslators = RecentTranslators.Except(viewModel.TranslatorID);


                    var type =(DeletedTranslators).GetType();
                    var DeletedCategories = RecentCategories.Except(viewModel.CategoryID);



                    var AddedAuthors = viewModel.AuthorID.Except(RecentAuthors);
                    var AddedTranslators = viewModel.TranslatorID.Except(RecentTranslators);
                    var AddedCategories = viewModel.CategoryID.Except(RecentCategories);


                    if (DeletedAuthors.Count() != 0)
                        _context.RemoveRange(DeletedAuthors.Select(a => new Author_Book { AuthorID = a, BookID = viewModel.BookID }).ToList());

                    if (DeletedTranslators.Count() != 0)
                        _context.RemoveRange(DeletedTranslators.Select(a => new Book_Translator { TranslatorID = a, BookID = viewModel.BookID }).ToList());


                    if (DeletedCategories.Count() != 0)
                        _context.RemoveRange(DeletedCategories.Select(a => new Book_Category { CategoryID = a, BookID = viewModel.BookID }).ToList());



                    if (AddedAuthors.Count() != 0)
                        _context.AddRange(AddedAuthors.Select(a => new Author_Book { AuthorID = a, BookID = viewModel.BookID }).ToList());

                    if (AddedTranslators.Count() != 0)
                        _context.AddRange(AddedTranslators.Select(a => new Book_Translator { TranslatorID = a, BookID = viewModel.BookID }).ToList());

                    if (AddedCategories.Count() != 0)
                        _context.AddRange(AddedCategories.Select(a => new Book_Category { CategoryID = a, BookID = viewModel.BookID }).ToList());


                    await _context.SaveChangesAsync();
                    ViewBag.MsgSuccess = "دخیره تغییرات با موفقیت انجام شد";

                    return View(viewModel);
                }
                catch
                {
                    ViewBag.MsgFaild = "در ذخیره تغییرات خطایی رخ داده است";
                    return View(viewModel);
                }
            }
            else
            {
                ViewBag.MsgFaild = "اطلاعات فرم نامعتبر است";
                return View(viewModel);
            }
        }


        public async Task<IActionResult> SearchByISBN(string ISBN)
        {
            if (ISBN != null)
            {
                var Book = (from b in _context.Books
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

    }
}