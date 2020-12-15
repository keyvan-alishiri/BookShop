using BookShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.UnitOfWork
{
  public interface IUnitOfWork
    {
        IRepositoryBase<TEntity> BaseRepository<TEntity>() where TEntity : class;
        Task Commit();
    }
}
