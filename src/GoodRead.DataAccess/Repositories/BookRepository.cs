using GoodRead.DataAccess.DbContexts;
using GoodRead.DataAccess.Interfaces;
using GoodRead.Domain.Entities.Books;

namespace GoodRead.DataAccess.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IEnumerable<Book>> SearchAsync(string search)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            var entity = _dbSet.Where(x => x.Title.Contains(search));
            return (IEnumerable<Book>)entity;
        }

        public async Task<IEnumerable<Book>> GetAllAsync() => _dbSet;
    }
}
