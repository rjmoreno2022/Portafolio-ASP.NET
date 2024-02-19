using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoriosProyectos repositoriosProyectos;

        public HomeController(ILogger<HomeController> logger, IRepositoriosProyectos repositoriosProyectos)
        {
            _logger = logger;
            this.repositoriosProyectos = repositoriosProyectos;
        }

        public IActionResult Index()
        {
            var repositorioProyectos = new RepositoriosProyectos();
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
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