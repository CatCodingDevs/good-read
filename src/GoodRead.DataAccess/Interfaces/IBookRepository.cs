using GoodRead.Domain.Entities.Books;
using System.Collections.Generic;

namespace GoodRead.DataAccess.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<IEnumerable<Book>> SearchAsync(string search);
        Task<IEnumerable<Book>> GetAllAsync();
    }
}
