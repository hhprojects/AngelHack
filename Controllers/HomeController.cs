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


        public IActionResult Index()
        {
            DbSet<Posts> dbs = _dbCtx.Posts;
            return View();
        }
    }
}
