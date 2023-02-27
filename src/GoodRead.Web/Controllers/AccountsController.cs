using Microsoft.AspNetCore.Mvc;

namespace GoodRead.Web.Controllers;
[Route("accounts")]
public class AccountsController : Controller
{
    [HttpGet("login")]
    public IActionResult Login()
    {
        return View("Login");
    }

    [HttpGet("register")]
    public IActionResult Register()
    {
        return View("Register");
    }
}
