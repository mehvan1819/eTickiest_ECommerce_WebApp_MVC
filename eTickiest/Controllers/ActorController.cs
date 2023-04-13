using eTickiest.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickiest.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;
        public ActorController(AppDbContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            var actorList = _context.Actors.ToList();
            return View(actorList);
        }
    }
}
