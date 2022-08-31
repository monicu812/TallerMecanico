using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
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
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult CrearUsuario()
        {
            return View();
        }

        public IActionResult Cliente()
        {
            return View();
        }

        public IActionResult Empleado()
        {
            return View();
        }

        public IActionResult Vehiculo()
        {
            return View();
        }

               
        public IActionResult Historial()
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