using Livre_Project.Data;
using Microsoft.AspNetCore.Mvc;

namespace Livre_Project.Controllers
{
    public class LivresController : Controller
    {
        private readonly AppDbContext _context;


        public LivresController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var AllLivres = _context.Livres.ToList();
            return View();
        }
    }
}
