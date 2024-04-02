using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Services;

namespace Projekt_ASP_NET.Controllers
{
    public class VehicleController : Controller
    {
        private readonly VehicleService _vehicleService;
        public VehicleController(VehicleService vehicleService)
        {
                _vehicleService = vehicleService;
        }
        List<Vehicle> _vehicles = new List<Vehicle>()
        {
                new Vehicle
                {
                    Id = 1,
                    Name = "Hulajnoga błyskawica",
                    Brand = "PowerScooter",
                    Image = null,
                    IsAvailable = true,
                    PricePerHour = 2,
                    PricePerDay = 15,
                    PricePerMonth = 320,
                    PurchasePrice = 1750,
                    BranchId = 1,
                    Length = 1.1f,
                    Width = 0.7f,
                    Weight = 22,
                    Color = "Blue",
                    Horsepower = 15,
                    IsCombustionVehicle = false,
                    IsElectricVehicle = true
                },
                new Vehicle
                {
                    Id = 2,
                    Name = "Rower górski",
                    Brand = "Stormy",
                    Image = null,
                    IsAvailable = true,
                    PricePerHour = 3,
                    PricePerDay = 20,
                    PricePerMonth = 380,
                    PurchasePrice = 2100,
                    BranchId = 1,
                    Length = 1.2f,
                    Width = 0.8f,
                    Weight = 23,
                    Color = "Purple",
                    Horsepower = null,
                    IsCombustionVehicle = false,
                    IsElectricVehicle = false
                },
                new Vehicle
                {
                    Id = 3,
                    Name = "Monocykl",
                    Brand = "OneWay",
                    Image = null,
                    IsAvailable = false,
                    PricePerHour = 1,
                    PricePerDay = 10,
                    PricePerMonth = 230,
                    PurchasePrice = 1050,
                    BranchId = 1,
                    Length = 0.6f,
                    Width = 0.4f,
                    Weight = 8,
                    Color = "Black",
                    Horsepower = null,
                    IsCombustionVehicle = false,
                    IsElectricVehicle = false
                }
        };
        public IActionResult All()
        {
         
            return View(_vehicles);
        }
        public IActionResult One(int id)
        {
            ViewBag.Id = id;
            var result = _vehicles.Find(x => x.Id == id);
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Vehicle body)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine(body.Id + body.Color + body.Name);
                // logika dodania do bazy ...
                return View(body);
            }
            return RedirectToAction("Add", FormMethod.Get);
        }
    }
}
