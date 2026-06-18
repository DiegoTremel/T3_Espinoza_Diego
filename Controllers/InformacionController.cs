using Microsoft.AspNetCore.Mvc;

namespace T3_Espinoza_Diego.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult ArquitecturaSoftware()
        {
            return View();
        }

        public IActionResult DisenoSoftware()
        {
            return View();
        }
    }
}
