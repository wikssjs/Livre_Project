using Livre_Project.Data;
using Livre_Project.Data.Services;
using Livre_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Livre_Project.Controllers
{
    public class FavorisController : Controller
    {
        private readonly AppDbContext _context;


        public FavorisController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var LivreInscrits =
            from l in _context.Livres
            join lut in _context.Livres_Utilisateurs
            on l.Id equals lut.LivreId
            where lut.UtilisateurId == 1
            select new Livre
            {
                Id = l.Id,
                ImgUrl = l.ImgUrl,
                Auteur = l.Auteur,
                Titre = l.Titre,
                Description = l.Description,
            };

            var james = LivreInscrits.ToArray().ToList();
            return View(james);
        }

        [HttpPost]
        public async Task<IActionResult> Index(int id)
        {
            var utilisateur =await _context.Livres_Utilisateurs.FirstOrDefaultAsync(l => l.LivreId== id&&l.UtilisateurId==1);
            _context.Livres_Utilisateurs.Remove(utilisateur);
           await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
