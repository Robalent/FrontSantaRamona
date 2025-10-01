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
            // lista de mascotas o redirección a la vista
            return View();
        }
        public IActionResult InfoAdopcion(int id)
        {
            // Diccionarios simulando tablas relacionadas
            var razas = new Dictionary<int, string>
    {
        {1, "De Raza"},
        {2, "Mestizo"}
       
    };

            var especies = new Dictionary<int, string>
    {
        {1, "Perro"},
        {2, "Gato"}
    };

            var estados = new Dictionary<int, string>
    {
        {1, "Disponible"},
        {2, "Adoptado"}
    };

            var tamanos = new Dictionary<int, string>
    {
        {1, "Grande"},
        {2, "Mediano"},
        {3, "Chico"}
    };

            // Lista simulada de animales
            var animales = new List<Adopcion>
    {
        new Adopcion {
            Id_Animal = 1,
            Nombre = "Luna",
            Edad = 2,
            Imagen = "/images/adoptados/Labrador.luna.jpg",
            Id_Raza = 1,
            Id_Especie = 1,
            Id_Estado = 1,
            Historia = "Es muy cariñosa y le gusta jugar.",
            FechaIngreso = DateTime.Now.AddMonths(-2),
            Id_Pension = null,
            Id_Tamano = 1
        },
        new Adopcion {
            Id_Animal = 2,
            Nombre = "Max",
            Edad = 3,
            Imagen = "/images/adoptados/Beagle.max.jpg",
            Id_Raza = 1,
            Id_Especie = 1,
            Id_Estado = 2,
            Historia = "Le encanta correr y es muy activo.",
            FechaIngreso = DateTime.Now.AddMonths(-6),
            Id_Pension = 1,
            Id_Tamano = 2
        },
        new Adopcion {
    Id_Animal = 3,
    Nombre = "Onix",
    Edad = 1,
    Imagen = "/images/adoptados/Caniche.onix.jpg",
    Id_Raza = 1, // Caniche
    Id_Especie = 1,
    Id_Estado = 2,
    Historia = "Es dulce y jugueton, le encanta saltar.",
    FechaIngreso = DateTime.Now.AddMonths(-4),
    Id_Pension = 1,
    Id_Tamano = 2
},

new Adopcion {
    Id_Animal = 4,
    Nombre = "Toby",
    Edad = 4,
    Imagen = "/images/adoptados/Caniche.toby.jpg",
    Id_Raza = 1, // Caniche
    Id_Especie = 1,
    Id_Estado = 2,
    Historia = "Muy cariñoso y le gusta pasear.",
    FechaIngreso = DateTime.Now.AddMonths(-5),
    Id_Pension = 1,
    Id_Tamano = 1
},

new Adopcion {
    Id_Animal = 5,
    Nombre = "Coco",
    Edad = 3,
    Imagen = "/images/adoptados/Caniche.coco.jpeg",
    Id_Raza = 1, // Caniche
    Id_Especie = 1,
    Id_Estado = 2,
    Historia = "Le encanta jugar con pelotas y es muy activo.",
    FechaIngreso = DateTime.Now.AddMonths(-3),
    Id_Pension = 1,
    Id_Tamano = 2
},

new Adopcion {
    Id_Animal = 6,
    Nombre = "Rocco",
    Edad = 5,
    Imagen = "/images/adoptados/Mestizo.rocco.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Especie = 1,
    Id_Estado = 2,
    Historia = "Rescatado de la calle, es muy leal y protector.",
    FechaIngreso = DateTime.Now.AddMonths(-6),
    Id_Pension = 2,
    Id_Tamano = 1
},

new Adopcion {
    Id_Animal = 7,
    Nombre = "Maya",
    Edad = 2,
    Imagen = "/images/adoptados/Mestizo.maya.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Especie = 1,
    Id_Estado = 2,
    Historia = "Cariñosa y tranquila, se lleva bien con todos.",
    FechaIngreso = DateTime.Now.AddMonths(-2),
    Id_Pension = 2,
    Id_Tamano = 3
},

new Adopcion {
    Id_Animal = 8,
    Nombre = "Simba",
    Edad = 3,
    Imagen = "/images/adoptados/Mestizo.simba.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Especie = 1,
    Id_Estado = 2,
    Historia = "Muy curioso y juguetón, le encanta explorar.",
    FechaIngreso = DateTime.Now.AddMonths(-4),
    Id_Pension = 2,
    Id_Tamano = 1
},

new Adopcion {
    Id_Animal = 9,
    Nombre = "Iris",
    Edad = 1,
    Imagen = "/images/adoptados/Mestizo.iris.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Especie = 1,
    Id_Estado = 1,
    Historia = "Cariñosa y tranquila, se lleva bien con todos.",
    FechaIngreso = DateTime.Now.AddMonths(-2),
    Id_Pension = 2,
    Id_Tamano = 3
},
new Adopcion {
    Id_Animal = 10,
    Nombre = "Odin",
    Edad = 1,
    Imagen = "/images/adoptados/Mestizo.odin.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Especie = 1,
    Id_Estado = 1,
    Historia = "Jugueton y amoroso, se lleva bien solo con perros.",
    FechaIngreso = DateTime.Now.AddMonths(-2),
    Id_Pension = 2,
    Id_Tamano = 3
},

    };

            var mascotaSeleccionada = animales.FirstOrDefault(a => a.Id_Animal == id);

            if (mascotaSeleccionada == null)
                return NotFound();

            // Paso los diccionarios por ViewBag para usarlos en la vista
            ViewBag.Razas = razas;
            ViewBag.Especies = especies;
            ViewBag.Estados = estados;
            ViewBag.Tamanos = tamanos;

            return View(mascotaSeleccionada);
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
