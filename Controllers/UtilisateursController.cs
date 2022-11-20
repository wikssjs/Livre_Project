using Livre_Project.Data;
using Microsoft.AspNetCore.Mvc;

namespace Livre_Project.Controllers
{
    public class UtilisateursController : Controller
    {
        AppDbContext _context;


        public UtilisateursController(AppDbContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            var AllUtilisateurs = _context.Utilisateurs.ToList();
            return View(AllUtilisateurs);
        }
    }
}
