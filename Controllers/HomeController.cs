using System.Diagnostics;
using FrontSantaRamona.AdopcionModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public IActionResult InfoAdopcion(int id, int? page)
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
            Id_Tamano = 1,
            Historia = "Fue encontrada en una plaza, temblando de frío. Hoy, con una manta y una caricia, mueve la cola como si nunca hubiera sufrido. Solo le falta un hogar.",

        },
        new Adopcion {
            Id_Animal = 2,
            Nombre = "Max",
            Edad = 3,
            Imagen = "/images/adoptados/Beagle.max.jpg",
            Id_Raza = 1,
            Id_Tamano = 2,
            Historia = "Vivió atado casi toda su vida. Ahora que conoció la libertad, corre sin parar. Busca una familia que lo acompañe en cada carrera.",
        },
        new Adopcion {
    Id_Animal = 3,
    Nombre = "Onix",
    Edad = 1,
    Imagen = "/images/adoptados/Caniche.onix.jpg",
    Id_Raza = 1, // Caniche
    Id_Tamano = 2,
    Historia = "Sobrevivió en la calle comiendo lo que encontraba. Hoy, agradece cada plato con besos y saltos. Su mayor deseo es una familia de verdad.",
},

new Adopcion {
    Id_Animal = 4,
    Nombre = "Toby",
    Edad = 4,
    Imagen = "/images/adoptados/Caniche.toby.jpg",
    Id_Raza = 1, // Caniche
    Id_Tamano = 1,
    Historia = "Llegó flaco y con miedo. Poco a poco, volvió a confiar en las personas. Ahora sueña con una cama calentita y muchas caricias.",
},

new Adopcion {
    Id_Animal = 5,
    Nombre = "Coco",
    Edad = 3,
    Imagen = "/images/adoptados/Caniche.coco.jpeg",
    Id_Raza = 1, // Caniche
    Id_Tamano = 2,
    Historia = "Rescatado de una zanja, con apenas fuerzas para caminar. Hoy es pura energía y alegría. Busca un hogar que valore su segunda oportunidad.",
},

new Adopcion {
    Id_Animal = 6,
    Nombre = "Rocco",
    Edad = 5,
    Imagen = "/images/adoptados/Mestizo.rocco.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Tamano = 1,
    Historia = "Era invisible para todos en la calle, hasta que alguien lo miró con amor. Ahora espera que otra persona lo mire igual y lo elija para siempre.",
},

new Adopcion {
    Id_Animal = 7,
    Nombre = "Maya",
    Edad = 2,
    Imagen = "/images/adoptados/Mestizo.maya.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Tamano = 3,
    Historia = "Cachorrita abandonada en una caja. Sus ojitos curiosos no dejan de explorar. Solo necesita alguien que la acompañe en cada aventura.",
},

new Adopcion {
    Id_Animal = 8,
    Nombre = "Simba",
    Edad = 3,
    Imagen = "/images/adoptados/Mestizo.simba.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Tamano = 1,
    Historia = "Pasó meses en un basural, pero nunca perdió la alegría. Hoy juega con todo lo que encuentra y sueña con jugar en el patio de su nueva casa.",
},

new Adopcion {
    Id_Animal = 9,
    Nombre = "Iris",
    Edad = 1,
    Imagen = "/images/adoptados/Mestizo.iris.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Tamano = 3,
    Historia = "Le tenía miedo a todo, incluso a su sombra. Con paciencia, volvió a confiar. Hoy sonríe con cada caricia, pero sueña con hacerlo en su propio hogar.",
},
new Adopcion {
    Id_Animal = 10,
    Nombre = "Odin",
    Edad = 1,
    Imagen = "/images/adoptados/Mestizo.odin.jpeg",
    Id_Raza = 2, // Mestizo
    Id_Tamano = 3,
    Historia = "Fue encontrado en una estación de tren, siguiendo a la gente con la esperanza de que alguien lo lleve. Todavía espera a esa persona especial que lo elija.",
},

    };

            var mascota = animales.FirstOrDefault(a => a.Id_Animal == id);
            if (mascota == null) return NotFound();

            // 🔹 Mover esto antes del return
            ViewBag.Razas = razas;
            ViewBag.Especies = especies;
            ViewBag.Tamanos = tamanos;
            ViewBag.Page = page ?? 1;

            return View(mascota);


        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        

    }

}
