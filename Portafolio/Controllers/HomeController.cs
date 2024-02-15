using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {  new Proyecto
            {
                Titulo = "Amazon",
                Description = "E-Commerce realizado en ASP-NET Core",
                Link = "https://www.amazon.com/",
                ImagenURL = "/imagenes/amazon.png"
            },
            new Proyecto
            {
                Titulo = "New York Times",
                Description = "Pagina de Noticias en React",
                Link = "https://www.nytimes.com/international/",
                ImagenURL = "/imagenes/nyt.png"
            },
            new Proyecto
            {
                Titulo = "Reddit",
                Description = "Red Social para compartir en comunidades",
                Link = "https://www.reddit.com/",
                ImagenURL = "/imagenes/reddit.png"
            },
            new Proyecto
            {
                Titulo = "Steam",
                Description = "Tienda en linea para comprar videojuegos",
                Link = "https://store.steampowered.com/",
                ImagenURL = "/imagenes/steam.png"
            }
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}