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

        public BookService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
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

        //public async Task<IEnumerable<Book>> GetAllAsync(PaginationParams @params)
        //{
        //    return await _unitOfWork.BookRepository.GetAllAsync();
        //}

        public async Task<BookViewModel> GetAsync(long id)
        {
            var book = await _unitOfWork.BookRepository.GetAsync(id);

            if (book is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Book not found");

            return book;
        }

        //public async Task<BookViewModel> SearchAsync(string search)
        //{
        //    var title = await _unitOfWork.BookRepository.SearchAsync(search);

        //    if (title is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Book not found");

        //    return (BookViewModel)title;
        //}

        public async Task<PagedList<BookViewModel>> SearchByNameAsync(string title, PaginationParams @params)
        {

            var res = _unitOfWork.BookRepository.Where(x => x.Title.ToLower().Contains(title.ToLower())).Select(
                book => new BookViewModel()
                {
                    //Id = product.Id,
                    //ProductName = product.ProductName,
                    //ProductDescription = product.ProductDescription,
                    //Price = product.Price,
                    //ImagePath = product.ImagePath
                    Title = book.Title,
                    Description = book.Description,
                    Price = book.Price,
                    ImagePath = book.ImagePath,
                    PageNumber = book.PageNumber,
                    BookLanguage = book.BookLanguage,
                    ISBN = book.ISBN,
                    Publisher = book.Publisher,
                    PublishedYear = book.PublishedYear
                });



            return await PagedList<BookViewModel>.ToPagedListAsync(res, @params);
        }

        public async Task<bool> UpdateAsync(long bookId, BookCreateDto bookCreateDto)
        {
            var book = await _unitOfWork.BookRepository.GetAsync(bookId);

            if (book is null) throw new StatusCodeException(HttpStatusCode.NotFound, "Book not found");

            var updatedBook = (Book)bookCreateDto;

            await _unitOfWork.BookRepository.UpdateAsync(bookId, updatedBook);

            return true;
        }

        public async Task<PagedList<BookViewModel>> GetAllAsync(PaginationParams @params)
        {
            var res = from book in await _unitOfWork.BookRepository.GetAllAsync()
                        select new BookViewModel()
                        {
                            Title = book.Title,
                            Description = book.Description,
                            Price = book.Price,
                            ImagePath = book.ImagePath,
                            PageNumber = book.PageNumber,
                            BookLanguage = book.BookLanguage,
                            ISBN = book.ISBN,
                            Publisher = book.Publisher,
                            PublishedYear = book.PublishedYear
                        };
            return await PagedList<BookViewModel>.ToPagedListAsync(res, @params);
        }
    }
}
