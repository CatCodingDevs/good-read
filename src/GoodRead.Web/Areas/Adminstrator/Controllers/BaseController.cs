using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoodRead.Web.Areas.Adminstrator.Controllers
{
    [Area("adminstrator")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class BaseController : Controller
    {
    }
}
