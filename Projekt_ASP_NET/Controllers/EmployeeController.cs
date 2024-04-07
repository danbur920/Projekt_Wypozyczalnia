using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User body)
        {
            if (!ModelState.IsValid)
            {
                // logika dodania do bazy ... 
                return View(body);
            }

            return RedirectToAction("Add", FormMethod.Get);
        }
    }
}
