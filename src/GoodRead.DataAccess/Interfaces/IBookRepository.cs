using GoodRead.Domain.Entities.Books;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GoodRead.DataAccess.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<IEnumerable<Book>> SearchAsync(string search);
        Task<IQueryable<Book>> GetAllAsync();
        public IQueryable<Book> Where(Expression<Func<Book, bool>> expression);
    }
}
