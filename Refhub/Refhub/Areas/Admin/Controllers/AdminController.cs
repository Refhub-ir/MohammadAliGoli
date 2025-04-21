using Microsoft.AspNetCore.Mvc;

namespace Refhub.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
