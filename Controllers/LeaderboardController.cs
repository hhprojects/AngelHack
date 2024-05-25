using Microsoft.AspNetCore.Mvc;

namespace AngelHack.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly AppDbContext _dbCtx;

        public LeaderboardController(AppDbContext dbContext)
        {
            _dbCtx = dbContext;
        }


        public IActionResult Index()
        {
			DbSet<AppUser> dbs = _dbCtx.AppUser;
            List<AppUser> users = dbs.ToList();
			return View();
        }
    }
}
