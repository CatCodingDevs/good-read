using GoodRead.Service.DTOs.Books;

namespace GoodRead.Service.Interfaces.Books
{
    public interface IBookService
    {
        Task<bool> CreateAsync(BookCreateDto bookCreateDto);
    }
}
