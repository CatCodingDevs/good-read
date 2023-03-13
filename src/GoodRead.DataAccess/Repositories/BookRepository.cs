using GoodRead.DataAccess.DbContexts;
using GoodRead.DataAccess.Interfaces;
using GoodRead.Domain.Entities.Books;
using System.Linq;
using System.Linq.Expressions;

namespace GoodRead.DataAccess.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Book>> SearchAsync(string search)
        {
            var entity = _dbSet.Where(x => x.Title.Contains(search));
            return (IEnumerable<Book>)entity;
        }

        public async Task<IQueryable<Book>> GetAllAsync() => _dbSet;

        public IQueryable<Book> Where(Expression<Func<Book, bool>> expression)
            => _dbSet.Where(expression);
    }
}
