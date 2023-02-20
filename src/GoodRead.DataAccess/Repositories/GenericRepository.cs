using GoodRead.DataAccess.DbContexts;
using GoodRead.DataAccess.Interfaces;
using GoodRead.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace GoodRead.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public virtual async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> DeleteAsync(long id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity is not null)
            {
                _dbSet.Remove(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to remove");
        }

        public virtual async Task<T> GetAsync(long id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity ?? throw new NullReferenceException("Not found entity to get");
        }

        public virtual async Task<T> UpdateAsync(long id, T entity)
        {
            var oldEntity = await _dbSet.FindAsync(id);
            if (oldEntity is not null)
            {
                entity.Id = id;
                _dbSet.Update(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            else throw new NullReferenceException("Not found entity to update");
        }
    }
}
