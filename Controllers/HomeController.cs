using System.Data.Common;
using Microsoft.AspNetCore.Mvc;

namespace AngelHack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbCtx;

        public HomeController(AppDbContext dbContext)
        {
            _dbCtx = dbContext;
        }

        [Authorize]
        public IActionResult Index()
        {
            DbSet<Posts> dbs = _dbCtx.Posts;
            List<Posts> posts = dbs.ToList();
            return View(posts);
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
