using Microsoft.AspNetCore.Mvc;

namespace GoodRead.Web.Areas.Adminstrator.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
