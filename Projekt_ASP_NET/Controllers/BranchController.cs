using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Repository.Interfaces;
using Projekt_ASP_NET.Services;
using Projekt_ASP_NET.Services.Interfaces;
using Projekt_ASP_NET.ViewModels;

namespace Projekt_ASP_NET.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        List<Branch> _branches = new List<Branch>()
        {
            new Branch{Id = 1, Locality = "Katowice", NumberOfVehicles = 5},
            new Branch{Id = 2, Locality = "Warszawa", NumberOfVehicles = 12},
            new Branch{Id = 3, Locality = "Bielsko-Biała", NumberOfVehicles = 7},
            new Branch{Id = 4, Locality = "Ustroń", NumberOfVehicles = 4}
        };
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Branch branch)
        {
            if (ModelState.IsValid)
            {
                await _branchService.Add(branch);
                return RedirectToAction("All");
            }
            return View(branch);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var branch = await _branchService.GetById(id);
            if (branch != null)
            {
                await _branchService.Delete(id);
                return RedirectToAction("All");
            }
            return NotFound();
        }

        public async Task<IActionResult>  All()
        {
            return View(await _branchService.GetAll());
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
