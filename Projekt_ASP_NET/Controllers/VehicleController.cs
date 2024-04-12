using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Services;
using Projekt_ASP_NET.Services.Interfaces;
using Projekt_ASP_NET.ViewModels;

namespace Projekt_ASP_NET.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;
        private readonly IBranchService _branchService;

        public VehicleController(IVehicleService vehicleService, IBranchService branchService)
        {
            _vehicleService = vehicleService;
            _branchService = branchService;
        }
        //List<Vehicle> _vehicles = new List<Vehicle>()
        //{
        //        new Vehicle
        //        {
        //            Id = 1,
        //            Name = "Hulajnoga błyskawica",
        //            Brand = "PowerScooter",
        //            Image = null,
        //            IsAvailable = true,
        //            PricePerHour = 2,
        //            PricePerDay = 15,
        //            PricePerMonth = 320,
        //            PurchasePrice = 1750,
        //            BranchId = 1,
        //            Length = 1.1f,
        //            Width = 0.7f,
        //            Weight = 22,
        //            Color = "Blue",
        //            Horsepower = 15,
        //            IsCombustionVehicle = false,
        //            IsElectricVehicle = true
        //        },
        //        new Vehicle
        //        {
        //            Id = 2,
        //            Name = "Rower górski",
        //            Brand = "Stormy",
        //            Image = null,
        //            IsAvailable = true,
        //            PricePerHour = 3,
        //            PricePerDay = 20,
        //            PricePerMonth = 380,
        //            PurchasePrice = 2100,
        //            BranchId = 1,
        //            Length = 1.2f,
        //            Width = 0.8f,
        //            Weight = 23,
        //            Color = "Purple",
        //            Horsepower = null,
        //            IsCombustionVehicle = false,
        //            IsElectricVehicle = false
        //        },
        //        new Vehicle
        //        {
        //            Id = 3,
        //            Name = "Monocykl",
        //            Brand = "OneWay",
        //            Image = null,
        //            IsAvailable = false,
        //            PricePerHour = 1,
        //            PricePerDay = 10,
        //            PricePerMonth = 230,
        //            PurchasePrice = 1050,
        //            BranchId = 1,
        //            Length = 0.6f,
        //            Width = 0.4f,
        //            Weight = 8,
        //            Color = "Black",
        //            Horsepower = null,
        //            IsCombustionVehicle = false,
        //            IsElectricVehicle = false
        //        }
        //};
        public async Task<IActionResult> All()
        {
            var vehicles = await _vehicleService.GetAll();
            return View(vehicles);
        }
        public async Task<IActionResult> One(int id)
        {
            ViewBag.Id = id;
            //var result = _vehicles.Find(x => x.Id == id);
            return View(await _vehicleService.GetById(id));
        }
        [Authorize(Roles = "pracownik")]
        public async Task<IActionResult> Add()
        {
            var branches = await _branchService.GetAll();
            var viewModel = new VehicleViewModel
            {
                Vehicle = new Vehicle(),
                Branches = branches.Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Locality }).ToList()
            };
            return View(viewModel);
        }
        [Authorize(Roles ="pracownik")]
        [HttpPost]
        public async Task<IActionResult> Add(VehicleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _vehicleService.Add(viewModel.Vehicle);
                return RedirectToAction("All");
            }
            var branches = await _branchService.GetAll();
            viewModel.Branches = branches.Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Locality }).ToList();
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var vehicle = await _vehicleService.GetById(id);
            if (vehicle != null)
            {
                await _vehicleService.Delete(id);
                return RedirectToAction("All");
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var vehicle = await _vehicleService.GetById(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            var branches = await _branchService.GetAll();
            var branchSelectList = branches.Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Locality }).ToList();

            var viewModel = new VehicleViewModel
            {
                Vehicle = vehicle,
                Branches = branchSelectList
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(VehicleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _vehicleService.Update(viewModel.Vehicle);
                return RedirectToAction("All");
            }

            var branches = await _branchService.GetAll();
            var branchSelectList = branches.Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Locality }).ToList();

            viewModel.Branches = branchSelectList;

            return View(viewModel);
        }
    }
}
