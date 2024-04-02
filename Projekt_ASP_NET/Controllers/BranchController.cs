using Microsoft.AspNetCore.Mvc;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Repository.Interfaces;

namespace Projekt_ASP_NET.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchRepository _branchRepository;

        public BranchController(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        List<Branch> _branches = new List<Branch>()
        {
            new Branch{Id = 1, Locality = "Katowice", NumberOfVehicles = 5},
            new Branch{Id = 2, Locality = "Warszawa", NumberOfVehicles = 12},
            new Branch{Id = 3, Locality = "Bielsko-Biała", NumberOfVehicles = 7},
            new Branch{Id = 4, Locality = "Ustroń", NumberOfVehicles = 4}
        };


        public IActionResult All()
        {
            return View(_branches);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
