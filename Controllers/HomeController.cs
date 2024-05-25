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
            var userid = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            DbSet<AppUser> dbs = _dbCtx.AppUser;
            AppUser? user = dbs.Include(p => p.UserEvent).ThenInclude(p => p.Uevent).Where(p => p.UserId == userid)
                .FirstOrDefault();
            if (user != null)
            {
                return View(user);
            }
            return RedirectToAction("Index");
        }
    }
}
