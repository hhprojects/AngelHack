using Microsoft.AspNetCore.Mvc;

namespace AngelHack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
