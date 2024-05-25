using Microsoft.AspNetCore.Mvc;

namespace AngelHack.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
