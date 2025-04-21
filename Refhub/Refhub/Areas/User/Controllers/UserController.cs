using Microsoft.AspNetCore.Mvc;

namespace Refhub.Areas.User.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
