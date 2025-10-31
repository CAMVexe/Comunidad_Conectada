using Microsoft.AspNetCore.Mvc;
using Comunidad_Conectada.Models;
using Comunidad_Conectada.Data;

namespace Comunidad_Conectada.Controllers
{
    //GET
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            var personas = PersonasRepo.GetAll();
            return View(personas);
        }

        public IActionResult Create()
        {
            return View(new Persona());
        }

        //POST
        [HttpPost]
        public IActionResult Create(Persona model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            PersonasRepo.Agregar(model);

            TempData["Mensaje"] = $"Persona '{model.Nombre}' agregada correctamente.";
            return RedirectToAction(nameof(Index));
        }
    }
}
