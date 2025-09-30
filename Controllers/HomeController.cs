using System.Diagnostics;
using FrontSantaRamona.AdopcionModels;
using Microsoft.AspNetCore.Mvc;
using PruebaFront.Models;

namespace PruebaFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FormPersona()
        {
            return View("~/Views/Formularios/FormPersona.cshtml");
        }

        public IActionResult Voluntariado()
        {
            // Datos de prueba (mock)
            var voluntariados = new List<VoluntariadoInfo>
        {
            new VoluntariadoInfo { Id = 1, Texto = "Ser mayor de 18 años", ImagenUrl = "/images/juancito.jpg" },
            new VoluntariadoInfo { Id = 2, Texto = "Disponibilidad fines de semana", ImagenUrl = "/images/nina.jpg" },
            new VoluntariadoInfo { Id = 3, Texto = "Amor por los animales", ImagenUrl = "/images/sasha.jpg" }
        };

            // Esto lo enviás a la vista
            return View(voluntariados);
        }

        public IActionResult Donar()
        {
            return View();
        }

        public IActionResult Adopcion()
        {
            // Si no querés mostrar lista, podés dejar vacío o redirigir a InfoAdopcion
            return View();
        }

        public IActionResult InfoAdopcion(int id)
        {
            var mascotas = new List<Adopcion>
    {
        new Adopcion { Id = 1, Nombre = "Luna", Edad = "2 años", Estado = "Vacunada", Raza = "Labrador", ImagenUrl = "/images/adoptados/Labrador.luna.jpg" },
        new Adopcion { Id = 2, Nombre = "Max", Edad = "3 años", Estado = "Castrado", Raza = "Beagle", ImagenUrl = "/images/adoptados/Beagle.max.jpg" }
    };

            var mascotaSeleccionada = mascotas.FirstOrDefault(m => m.Id == id);
            if (mascotaSeleccionada == null)
                return NotFound();

            return View(mascotaSeleccionada);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
