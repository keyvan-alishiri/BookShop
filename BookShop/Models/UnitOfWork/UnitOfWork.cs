﻿using BookShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShop.Models.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public BookShopContext  _Context { get; }
        private IBookRepository _IBookRepository;

        public IBookRepository bookRepository
        {

            get
            {
                if(_IBookRepository==null)
                {
                    _IBookRepository = new BooksRepository(_Context);
                }

                return _IBookRepository;
            }

        }



        public UnitOfWork(BookShopContext context)

        {
            _Context = context;
        }

        public  IRepositoryBase<TEntity> BaseRepository<TEntity>() where TEntity :class
        {
            IRepositoryBase<TEntity> repository = new RepositoryBase<TEntity, BookShopContext>(_Context);
            return repository;
        }



        public async Task Commit()
        {
            await _Context.SaveChangesAsync();
        }





    }
}
