using BookShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using BookShop.Classes;

namespace BookShop.Models.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public BookShopContext  _Context { get; }
        private IBookRepository _IBookRepository;
        private readonly IConvertDate _convertDate;

        public IBookRepository BooksRepository
        {

            get
            {
                if(_IBookRepository==null)
                {
                    _IBookRepository = new BooksRepository(this ,_convertDate);
                }

                return _IBookRepository;
            }

        }



        public UnitOfWork(BookShopContext context , IConvertDate convertDate)

        {
            _Context = context;
            _convertDate = convertDate;
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
