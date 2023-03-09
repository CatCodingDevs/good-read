using GoodRead.DataAccess.Interfaces;
using GoodRead.Domain.Entities.Books;
using GoodRead.Service.DTOs.Books;
using GoodRead.Service.DTOs.Common;
using GoodRead.Service.DTOs.Orders;
using GoodRead.Service.Interfaces.Books;
using Microsoft.AspNetCore.Mvc;

namespace GoodRead.Web.Controllers;

[Route("books")]
public class BooksController : Controller
{
    private readonly IBookService _bookService;
    public BooksController(IBookService service)
    {
        this._bookService = service;
    }
    public async Task<IActionResult> Index()
    {
        var books = await _bookService.GetAllAsync();
        return View(books.ToList());
    }
    [HttpGet("search")]
    public async Task<IActionResult> SearchAsync(string titleName)
    {
        var book = await _bookService.SearchAsync(titleName);
        var dto = new BookViewModel()
        {
            
            Title = book.Title,
            Description = book.Description,
            Price = book.Price,
            ImagePath = book.ImagePath,
            PageNumber = book.PageNumber,
            BookLanguage = book.BookLanguage,
            ISBN = book.ISBN,
            Publisher = book.Publisher,
            PublishedYear = book.PublishedYear,
        };

        if (book is not null)
        {
            return NotFound();

        }
        return View("index", book);
    }
}
