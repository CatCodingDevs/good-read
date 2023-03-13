using GoodRead.DataAccess.Interfaces;
using GoodRead.Domain.Entities.Books;
using GoodRead.Service.DTOs.Books;
using Microsoft.AspNetCore.Mvc;

namespace GoodRead.Web.Areas.Adminstrator.Controllers
{
    public class BooksController : BaseController
    {
        private readonly IUnitOfWork unitOfWork;

        public BooksController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> GetAsync(long? id)
        {
            if (id is null) return BadRequest();
            var book = await unitOfWork.BookRepository.GetAsync(id.Value);
            return View(book);
        }

        public async Task<IActionResult> IndexAsync()
        {
            var books = await unitOfWork.BookRepository.GetAllAsync();
            return View(books.ToList());
        }

        public IActionResult AddRedirect()
        {
            return View("Add");
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAsync(BookCreateDto dto)
        {
            await unitOfWork.BookRepository.CreateAsync((Book)dto);
            return RedirectToAction("index", "books", new { area = "adminstrator" });
        }

        [ActionName("update")]
        public async Task<IActionResult> UpdateRedirectAsync([FromRoute] long? id)
        {

            if (id is null)
                return BadRequest();
            var book = await unitOfWork.BookRepository.GetAsync(id.Value);
            ViewBag.Title = book.Title;
            ViewBag.Description = book.Description;
            ViewBag.Price = book.Price;
            ViewBag.PageNumber = book.PageNumber;
            ViewBag.BookLanguage = book.BookLanguage;
            ViewBag.ISBN = book.ISBN;
            ViewBag.PublishedYear = book.PublishedYear;
            ViewBag.PublisherId = book.PublisherId;
            ViewBag.AuthorId = book.AuthorId;
            ViewBag.Genre = book.Genre;

            return View("update");
        }


        [HttpPost]
        public async Task<IActionResult> UpdateAsync([FromRoute] long id, BookCreateDto dto)
        {
            await unitOfWork.BookRepository.UpdateAsync(id, (Book)dto);
            return RedirectToAction("index", "books", new { area = "adminstrator" });
        }

        public async Task<IActionResult> DeleteAsync([FromRoute] long id)
        {
            return View();
        }
    }
}
