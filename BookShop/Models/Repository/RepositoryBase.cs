
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookShop.Models.Repository
{
    public class RepositoryBase<TEntity,TContext> : IRepositoryBase<TEntity> where TEntity : class where TContext : DbContext
    {
        protected TContext _context { get; set; }
        private DbSet<TEntity> dbSet;

        public RepositoryBase(TContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync()
        {
            return await dbSet.ToListAsync();

        }

        public async Task<TEntity> FindByID(Object id)
        {
            return await dbSet.FindAsync(id);
        }
        public async Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity,bool>> filter =null,Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>> orderby=null,params Expression<Func<TEntity,object>>[] includes)

        {
            IQueryable<TEntity> query = dbSet;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            if (filter != null)
            {
                query = query.Where(filter);
                    }
            if(orderby!=null)
            {
                query = orderby(query);

            }

            return await query.ToListAsync();

        }

        public async Task Create(TEntity entity)
        {
            await   dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity) => dbSet.Update(entity);

        public void Delete(TEntity entity) => dbSet.Remove(entity);

        public async Task CreateRange(IEnumerable<TEntity> entities) => await dbSet.AddRangeAsync();

        public void UpdateRange(IEnumerable<TEntity> entities) => dbSet.UpdateRange(entities);
        public void DeleteRange(IEnumerable<TEntity> entities) => dbSet.RemoveRange(entities);
    }

    public interface IRepositoryBase
    {
    }
}
