using Microsoft.AspNetCore.Mvc;

namespace GoodRead.Web.Controllers;

[Route("books")]
public class BooksController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
