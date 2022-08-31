using Microsoft.AspNetCore.Mvc;

namespace TallerMecanico.Controllers
{
    public class InicioSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
