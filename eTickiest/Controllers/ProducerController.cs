using eTickiest.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickiest.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _context;
        public ProducerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var producerlist = _context.Producers.ToList();
            return View(producerlist);
        }
    }
}
