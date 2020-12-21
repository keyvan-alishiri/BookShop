﻿using BookShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.Repository
{
   public interface IBookRepository
    {
        List<TreeViewCategory> GetAllCategories();
       void  BindSubCategories(TreeViewCategory category);
        List<BookIndexViewModel> GetAllBooks(string title, string ISBN, string Language, string Publisher, string Author, string Translator, string Category);

    }
}
