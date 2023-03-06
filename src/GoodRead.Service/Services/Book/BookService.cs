using GoodRead.DataAccess.Exceptions;
using GoodRead.DataAccess.Interfaces;
using GoodRead.Domain.Entities.Books;
using GoodRead.Service.DTOs.Books;
using GoodRead.Service.DTOs.Common;
using GoodRead.Service.Interfaces.Books;
using GoodRead.Service.Interfaces.Common;
using System.Net;

namespace GoodRead.Service.Services.Books
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaginatorService _paginator;

        public BookService(IUnitOfWork unitOfWork, IPaginatorService paginator)
        {
            this._unitOfWork = unitOfWork;
            this._paginator = paginator;
        }

        public async Task<bool> CreateAsync(BookCreateDto bookCreateDto, long bookId)
        {
            var book = (Book)bookCreateDto;
            book = await _unitOfWork.BookRepository.GetAsync(bookId);
            if (book is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Book not found");

            book.CreatedAt = DateTime.UtcNow;

            var result = await _unitOfWork.BookRepository.CreateAsync(book);

            return result is not null;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var book = await _unitOfWork.BookRepository.GetAsync(id);

            if (book is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Book not found");

            await _unitOfWork.BookRepository.DeleteAsync(id);

            return true;
        }

        public Task<IEnumerable<BookViewModel>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public async Task<BookViewModel> GetAsync(long id)
        {
            var book = await _unitOfWork.BookRepository.GetAsync(id);

            if (book is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Book not found");

            return book;
        }

        public async Task<bool> UpdateAsync(long bookId, BookCreateDto bookCreateDto)
        {
            var book = await _unitOfWork.BookRepository.GetAsync(bookId);

            if (book is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Book not found");

            var updatedBook = (Book)bookCreateDto;

            await _unitOfWork.BookRepository.UpdateAsync(bookId, updatedBook);

            return true;
        }
    }
}
