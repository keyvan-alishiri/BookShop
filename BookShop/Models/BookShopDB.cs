﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BookShop.Models
{

    [Table("BookInfo")]
    public class Book
    {
        //private ILazyLoader  LazyLoader { get; set; }   
        //private Language _language;
        //private Publisher _publisher; 
        //public Book()
        //{}

        //private Book(ILazyLoader lazyLoader)
        //{

        //    LazyLoader = lazyLoader;
        //}






        [Key]
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string File { get; set; }
        public int NumOfPages { get; set; }
        public short Weight { get; set; }
        public string ISBN { get; set; }
        public bool? IsPublish { get; set; }
        public DateTime? PublishDate { get; set; }
        public int PublishYear { get; set; }



        [DefaultValue("0")]
        public bool? Delete { get; set; }
        public int PublisherID { get; set; }

        [Column(TypeName ="image")]
        public byte[] Image { get; set; }
        public int LanguageID { get; set; }

        public virtual Language Language
        {
            //get => LazyLoader.Load(this, ref _language);
            //set => _language = value;

            get; set;
        }

        public virtual Publisher Publisher
        {
            //get => LazyLoader.Load(this, ref _publisher);
            //set => _publisher = value;


            get; set;
        }



        public virtual Discount Discount { get; set; }
        public virtual List<Author_Book> Author_Books { get; set; }
        public virtual List<Order_Book> Order_Books { get; set; }
        public virtual List<Book_Translator> book_Tranlators { get; set; }
        public virtual List<Book_Category> book_Categories { get; set; }
        
    }

    public class Book_Category
    {
        public int BookID { get; set; }
        public int CategoryID { get; set; }

        public virtual Book Book { get; set; }
        public virtual Category Category { get; set; }
    }


    public class Publisher
    {
        [Key]
        public int PublisherID { get; set; }
        [Display(Name ="ناشر")]
        [Required(ErrorMessage ="وارد نمودن نام {0} الزامی است")]
        public string PublisherName { get; set; }

        public virtual List<Book> Books { get; set; }
    }

    public class Book_Translator
    {
        public int TranslatorID { get; set; }
        public int BookID { get; set; }

        public virtual Book Book { get; set; }
        public virtual Translator Translator { get; set; }
    }

    public class Translator
    {
        [Key]
        public int TranslatorID { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        public virtual List<Book_Translator> book_Tranlators { get; set; }
    }

    public class Author_Book
    {
        //private Book _book;
        //private ILazyLoader  LazyLoader { get; set; }
        //public Author_Book(){}

        //private Author_Book(ILazyLoader lazyLoader)
        //{
        //    LazyLoader = lazyLoader;
        //}
        public int BookID { get; set; }
        public int AuthorID { get; set; }

        public virtual Book Book
        {
            //get => LazyLoader.Load(this,ref _book);
            //set => _book = value;
            get; set;
        }
        public virtual Author Author { get; set; }
    }

    public class Author
    {
        //private ILazyLoader LazyLoader { get; set; }

        //private List<Author_Book> _Author_Books;
        //public Author()
        //{

        //}

        //private Author(ILazyLoader lazyLoader )
        //{
        //    LazyLoader = lazyLoader;
        //}

        [Key]
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Author_Book> Author_Books
        {
            get;
            set;


            //get => LazyLoader.Load(this, ref _Author_Books);
            //set => _Author_Books = value;
        }
    }

    public class Discount
    {
        [Key,ForeignKey("Book")]
        public int BookID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte Percent { get; set; }

        public virtual Book Book { get; set; }
    }

    public class Language
    {
        public int LanguageID { get; set; }
        [Display(Name = "زبان")]
        public string LanguageName { get; set; }

        public virtual  List<Book> Books { get; set; }
    }

    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        [ForeignKey("category")]
        public int? ParentCategoryID { get; set; }

        public virtual Category category { get; set; }
        public virtual List<Category> categories { get; set; }
        public virtual List<Book_Category> book_Categories { get; set; }
    }


    public class Order
    {
        public string OrderID { get; set; }
        public long AmountPaid { get; set; }
        public string DispatchNumber { get; set; }
        public DateTime BuyDate { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<Order_Book> Order_Books { get; set; }
    }

    public class Order_Book
    {
        public string OrderID { get; set; }
        public int BookID { get; set; }

        public virtual Order Order { get; set; }
        public virtual Book Book { get; set; }
    }


    public class OrderStatus
    {
        public int OrderStatusID { get; set; }
        public string OrderStatusName { get; set; }

        public virtual List<Order> Orders { get; set; }
    }

    public class Customer
    {
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Mobile { get; set; }
        public string Tell { get; set; }
        public string Image { get; set; }

        public int Age { get; set; }

        public int CityID1 { get; set; }
        public int CityID2 { get; set; }

        public virtual City city1 { get; set; }
        public virtual City city2 { get; set; }
        public virtual List<Order> Orders { get; set; }
    }

    [Table("Province")]
    public class Provice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ProvinceID { get; set; }
        [Display(Name = "نام استان")]
        public string ProvinceName { get; set; }

        public virtual List<City> City { get; set; }
    }

    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CityID { get; set; }


        public string CityName { get; set; }

        [ForeignKey("Provice")]
        public int?  ProvinceID { get; set; }

        public virtual Provice Provice { get; set; }
        public virtual List<Customer> Customers1 { get; set; }
        public virtual List<Customer> Customers2 { get; set; }
    }
}
