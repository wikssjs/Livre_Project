using Livre_Project.Data;
using Livre_Project.Data.Services;
using Livre_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Livre_Project.Controllers
{
    public class LivresController : Controller
    {
        private readonly ILivresService _service;


        public LivresController(ILivresService service, AppDbContext context)
        {
            _service = service;
            //_favoriService = favoriService;
        }


        public async Task<IActionResult> Index()
        {
            var AllLivres = await _service.GetAllAsync();
            return View(AllLivres);
        }

       
        public async Task<IActionResult> Admin()
        {
            var AllLivres = await _service.GetAllAsync();
            return View(AllLivres);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Livre livre)
        {
            ModelState.Remove("Id");
            ModelState.Remove("Livre_Utilisateur");

            if (!ModelState.IsValid)
            {
                return View(livre);
            }
               await _service.AddAsync(livre);
                return RedirectToAction(nameof(Index));
        }

        public  async Task<IActionResult>Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }



        [HttpPost]
        public async Task<IActionResult>Edit(int id, Livre livre)
        {
            ModelState.Remove("Id");
            ModelState.Remove("Livre_Utilisateur");

            if (!ModelState.IsValid)
            {
                return View(livre);
            }
            await _service.UpdateAsync(id, livre);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Ajouter un livre en favoris
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Index(int id)
        {
            var AllLivres = await _service.GetAllAsync();
            await _service.AddFavoriAsync(id);
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }



        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Admin));
        }






    }
}
