using BookShop.Models;
using BookShop.Models.Repository;
using System.Threading.Tasks;


namespace BookShop.Areas.Admin.Controllers
{
    public interface IUnitOfWor
    {
        BookShopContext _Context { get; }
      
        IRepositoryBase<TEntity> BaseRepository<TEntity>() where TEntity : class;
        Task Commit();
    }

    
}