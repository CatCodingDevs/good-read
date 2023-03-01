using GoodRead.Service.Exceptions;
using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;

namespace GoodRead.Web.Controllers;
[Route("accounts")]
public class AccountsController : Controller
{
    private readonly IAccountService _service;
    public AccountsController(IAccountService acccountService)
    {
        this._service = acccountService;
    }

    [HttpGet("login")]
    public IActionResult Login()
    {
        return View("Login");
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(AccountLoginDto dto)
    {
        if (ModelState.IsValid)
        {
            try
            {
                string token = await _service.LogInAsync(dto);
                HttpContext.Response.Cookies.Append("X-Access-Token", token, new CookieOptions()
                {
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict
                });
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            catch (ModelErrorException modelError)
            {
                ModelState.AddModelError(modelError.Property, modelError.Message);
                return Login();
            }
            catch
            {
                return Login();
            }
        }
        else return Login();
    }

    [HttpGet("register")]
    public ViewResult Register() => View("Register");

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync(AccountRegisterDto accountRegisterDto)
    {
        if (ModelState.IsValid)
        {
            bool result = await _service.RegisterAsync(accountRegisterDto);
            if (result)
            {
                return RedirectToAction("login", "accounts", new { area = "" });
            }
            else
            {
                return Register();
            }
        }
        else return Register();
    }

    [HttpGet("verifyemail")]
    public ViewResult VerifyEmail() => View("VerifyEmail");

    [HttpPost("verifyemail")]
    public async Task<IActionResult> VerifyEmailAsync(VerifyEmailDto verifyEmailDto)
    {
        if (ModelState.IsValid)
        {
            bool result = await _service.VerifyEmailAsync(verifyEmailDto);
            if (result) 
            {
                //return RedirectToAction("Index", "Home", new { area = "" });
                return RedirectToAction("login", "accounts", new { area = "" });
            }
            else
            {
                return VerifyEmail();
            }
        }
        else return VerifyEmail();
    }

    [HttpGet("logout")]
    public IActionResult LogOut()
    {
        HttpContext.Response.Cookies.Delete("X-Access-Token");
        return RedirectToAction("Login", "Accounts", new { area = "" });
    }
}
