using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
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
        private readonly IMapper _mapper;

        public VehicleController(IVehicleService vehicleService, IBranchService branchService, IMapper mapper)
        {
            _vehicleService = vehicleService;
            _branchService = branchService;
            _mapper = mapper;
        }

        //public async Task<IActionResult> All(VehicleShowViewModel viewModel)
        //{
        //    viewModel = new VehicleShowViewModel()
        //    {
        //        Vehicles = (List<Vehicle>)await _vehicleService.GetAll(),
        //        Branches = (List<Branch>)await _branchService.GetAll()
        //    };

        //    return View(viewModel);
        //}

        public async Task<IActionResult> All(VehicleShowViewModel viewModel)
        {
            var vehicles = await _vehicleService.GetAll();
            var branches = await _branchService.GetAll();

            var mappedViewModel = new VehicleShowViewModel
            {
                Vehicles = _mapper.Map<List<Vehicle>>(vehicles),
                Branches = _mapper.Map<List<Branch>>(branches)
            };

            return View(mappedViewModel);
        }

        public async Task<IActionResult> One(int id)
        {
            ViewBag.Id = id;
            return View(await _vehicleService.GetById(id));
        }
        [Authorize(Policy = "AdminOrEmployee")]
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
        [Authorize(Policy = "AdminOrEmployee")]
        [HttpPost]
        public async Task<IActionResult> Add(VehicleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var vehicleBranchId = viewModel.Vehicle.BranchId;
                var vehicleBranch = await _branchService.GetById((int)vehicleBranchId);
                vehicleBranch.NumberOfVehicles++;

                await _vehicleService.Add(viewModel.Vehicle);
                return RedirectToAction("All");
            }
            var branches = await _branchService.GetAll();
            viewModel.Branches = branches.Select(b => new SelectListItem { Value = b.Id.ToString(), Text = b.Locality }).ToList();
            return View(viewModel);
        }

        [Authorize(Policy = "AdminOrEmployee")]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var vehicle = await _vehicleService.GetById(id);
            if (vehicle != null)
            {
                var vehicleBranch = await _branchService.GetById((int)vehicle.BranchId);
                vehicleBranch.NumberOfVehicles--;

                await _vehicleService.Delete(id);
                return RedirectToAction("All");
            }
            return NotFound();
        }

        [Authorize(Policy = "AdminOrEmployee")]
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

            //var viewModel = new VehicleViewModel
            //{
            //    Vehicle = vehicle,
            //    Branches = branchSelectList
            //};

            var viewModel = _mapper.Map<VehicleViewModel>(vehicle);
            viewModel.Branches = branchSelectList;

            return View(viewModel);
        }

        [Authorize(Policy = "AdminOrEmployee")]
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


