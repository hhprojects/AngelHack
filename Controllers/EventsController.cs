using Microsoft.AspNetCore.Mvc;

namespace AngelHack.Controllers
{
    public class EventsController : Controller
    {
        private readonly AppDbContext _dbCtx;

        public EventsController(AppDbContext dbContext)
        {
            _dbCtx = dbContext;
        }

        
        public IActionResult Index()
        {
            DbSet<VEvents> dbs = _dbCtx.VEvents;
            List<VEvents> vEvents = dbs.ToList();
            return View();
        }
    }
}
