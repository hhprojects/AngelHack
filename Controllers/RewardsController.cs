using Microsoft.AspNetCore.Mvc;

namespace AngelHack.Controllers
{
    public class RewardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
