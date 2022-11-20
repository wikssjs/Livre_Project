using Livre_Project.Data;
using Livre_Project.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace Livre_Project.Controllers
{
    public class LivresController : Controller
    {
        private readonly ILivresService _service;


        public LivresController(ILivresService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            var AllLivres = _service.getAll();
            return View(AllLivres);
        }
    }
}
