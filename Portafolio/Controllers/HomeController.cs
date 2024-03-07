using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        private readonly IRepositoriosProyectos repositoriosProyectos;
        private readonly IServicioEmail servicioEmail;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration,
            IRepositoriosProyectos repositoriosProyectos, IServicioEmail servicioEmail
            )
        {
            _logger = logger;
            this.configuration = configuration;
            this.repositoriosProyectos = repositoriosProyectos;
            this.servicioEmail = servicioEmail;
        }

        public IActionResult Index()
        {
            var apellido = configuration.GetValue<string>("Apellido");
            _logger.LogInformation("Esto es un mensaje del log. " + apellido);
            var proyectos = repositoriosProyectos.ObtenerProyectos().Take(3).ToList();

            var modelo = new HomeIndexViewModel() { 
                Proyectos = proyectos,
            };
            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Proyectos() 
        { 
            var proyectos = repositoriosProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        [HttpGet] //No es obligatorio poner esto, porque el HttpGet es el atributo por defecto.
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            await servicioEmail.Enviar(contactoViewModel);
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
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