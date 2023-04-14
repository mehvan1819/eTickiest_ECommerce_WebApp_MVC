using eTickiest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickiest.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _context;
        public ProducerController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var producerlist = await _context.Producers.ToListAsync();
            return View(producerlist);
        }
    }
}
