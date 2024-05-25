using Microsoft.AspNetCore.Mvc;

namespace AngelHack.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
