using Microsoft.AspNetCore.Mvc;

namespace Projekt_ASP_NET.Controllers
{
    public class VehiclesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
