using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult VehiclesAll()
        {
            var vehicleList = new List<Vehicle>
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
                    DetailId = 1,
                    BranchId = 1,
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
                    DetailId = 2,
                    BranchId = 1,
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
                    DetailId = 3,
                    BranchId = 1,
                }
            };
            return View(vehicleList);
        }

        public IActionResult VehiclesOne(int id)
        {
            ViewBag.VehicleId = id;

            var detailList = new List<Detail>
            {
                new Detail
                {
                    Id = 1,
                    Length = 1.1f,
                    Width = 0.7f,
                    Weight = 22,
                    Color = "Blue",
                    Horsepower = 15,
                    IsCombustionVehicle = false,
                    IsElectricVehicle = true,
                    VehicleId = 1

                },
                new Detail
                {
                    Id = 2,
                    Length = 1.2f,
                    Width = 0.8f,
                    Weight = 23,
                    Color = "Purple",
                    Horsepower = null,
                    IsCombustionVehicle = false,
                    IsElectricVehicle = false,
                    VehicleId = 2
                },
                new Detail
                {
                    Id = 3,
                    Length = 0.6f,
                    Width = 0.4f,
                    Weight = 8,
                    Color = "Black",
                    Horsepower = null,
                    IsCombustionVehicle = false,
                    IsElectricVehicle = false,
                    VehicleId = 3
                }
            };

            var result = detailList.Where(x => x.VehicleId == id).FirstOrDefault();
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
                return View(body);
            }

            return RedirectToAction("Add", FormMethod.Get);
        }
    }
}
