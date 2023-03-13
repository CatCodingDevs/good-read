using GoodRead.Domain.Entities.Books;
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
        public Task<PagedList<BookViewModel>> SearchByNameAsync(string name, DTOs.Common.PaginationParams @params);
        //Task<BookViewModel> SearchAsync(string search);
        //Task<IEnumerable<Book>> GetAllAsync(PaginationParams @params);
        public Task<PagedList<BookViewModel>> GetAllAsync(PaginationParams @params);
    }
}
