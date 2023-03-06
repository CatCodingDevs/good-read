using GoodRead.Domain.Enums;
using GoodRead.Service.DTOs.Books;
using GoodRead.Service.DTOs.Common;

namespace GoodRead.Service.Interfaces.Books
{
    public interface IBookService
    {
        Task<bool> CreateAsync(BookCreateDto bookCreateDto, long bookId);
        Task<bool> UpdateAsync(long bookId, BookCreateDto bookCreateDto);
        Task<bool> DeleteAsync(long id);
        Task<BookViewModel> GetAsync(long id);
        Task<IEnumerable<BookViewModel>> GetAllAsync(PaginationParams @params);
    }
}
