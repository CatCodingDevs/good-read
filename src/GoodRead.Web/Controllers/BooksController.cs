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
        var books = await _bookService.GetAllAsync(new PaginationParams(1, 10));
        return View(books.ToList());
    }
   
    [HttpGet("search")]
    public async Task<ViewResult> SearchAsync(string search, int page = 1)
    {
        PagedList<BookViewModel> result;
        if (!String.IsNullOrEmpty(search))
        {
            ViewBag.search = search;
            result = await _bookService.SearchByNameAsync(search, new PaginationParams(page, 10));
        }
        else
        {
            result = await _bookService.GetAllAsync(new PaginationParams(page, 10));
        }
        return View("index",  result);
    }
}
