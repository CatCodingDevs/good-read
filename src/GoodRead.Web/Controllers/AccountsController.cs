using GoodRead.Service.Exceptions;
using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
                var res = HttpContext.Request.Cookies["X-Access-Token"];
                Console.WriteLine(res);
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
        return Login();
    }

    [HttpGet("register")]
    public ViewResult Register() => View("Register");

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync(AccountRegisterDto accountRegisterDto)
    {
        if (ModelState.IsValid)
        {
            try
            {
                var result = await _service.RegisterAsync(accountRegisterDto);
                HttpContext.Response.Cookies.Append("user", result, new CookieOptions()
                {
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict
                });
                return RedirectToAction("sendcode", "accounts", new { area = "" });
            }
            catch
            {
                ModelState.AddModelError(nameof(accountRegisterDto.Email), "User already exists");
                return Register();
            }
        }
        return Register();
    }

    [HttpGet("verifyemail")]
    public async Task<IActionResult> VerifyEmail()
    {
        try
        {
            var email = JsonConvert.DeserializeObject<AccountRegisterDto>(HttpContext.Request.Cookies["user"]).Email;
            return View("VerifyEmail");
        }
        catch
        {
            return RedirectToAction("register", "accounts", new { area = "" });
        }
    }

    [HttpGet("sendcode")]
    public async Task<IActionResult> SendCodeAsync()
    {
        await _service.SendCodeAsync(new SendToEmailDto() { Email = JsonConvert.DeserializeObject<AccountRegisterDto>(HttpContext.Request.Cookies["user"]).Email });
        return RedirectToAction("verifyemail", "accounts", new { area = "" });
    }


    [HttpPost("verifyemail")]
    public async Task<IActionResult> VerifyEmailAsync(VerifyEmailDto verifyEmailDto)
    {
        try
        {
            var user = JsonConvert.DeserializeObject<AccountRegisterDto>(HttpContext.Request.Cookies["user"]);

            bool result = await _service.VerifyEmailAsync(user, verifyEmailDto);
            if (result)
            {
                HttpContext.Response.Cookies.Delete("user");
                return RedirectToAction("login", "accounts", new { area = "" });
            }
            ModelState.AddModelError(nameof(verifyEmailDto.Code), "Code is wrong");
            return await VerifyEmail();
        }
        catch
        {
            return await VerifyEmail();
        }
    }

    [HttpGet("logout")]
    public IActionResult LogOut()
    {
        HttpContext.Response.Cookies.Delete("X-Access-Token");
        return RedirectToAction("Login", "Accounts", new { area = "" });
    }
}
