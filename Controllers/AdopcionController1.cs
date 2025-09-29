using Microsoft.AspNetCore.Mvc;
using FrontSantaRamona.AdopcionModels;
using System.Collections.Generic;

namespace FrontSantaRamona.Controllers
{
    public class AdopcionController : Controller
    {
        public IActionResult Index()
        {
            var mascotas = new List<Adopcion>
            {
                new Adopcion { Id = 1, Nombre = "Luna", Edad = "2 años", Estado = "Vacunada", Raza = "Labrador", ImagenUrl = "/images/luna.jpg" },
                new Adopcion { Id = 2, Nombre = "Max", Edad = "3 años", Estado = "Castrado", Raza = "Beagle", ImagenUrl = "/images/max.jpg" }
            };

            return View(mascotas); // busca Views/Adopcion/Index.cshtml
        }
    }
}
