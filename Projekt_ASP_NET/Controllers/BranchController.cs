using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Packaging;
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
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public BranchController(IBranchService branchService, UserManager<User> userManager, IMapper mapper)
        {
            _branchService = branchService;
            _userManager = userManager;
            _mapper = mapper;
        }


        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var usersWithRoles = await _userManager.GetUsersInRoleAsync("pracownik");
            usersWithRoles.AddRange(await _userManager.GetUsersInRoleAsync("admin"));

            var branchViewModel = new BranchViewModel
            {
                Branch = new Branch(),
                //Users = usersWithRoles.Select(u => new SelectListItem { Value = u.Id, Text = u.Email }).ToList()
                Users = _mapper.Map<List<SelectListItem>>(usersWithRoles)
            };

            return View(branchViewModel);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> Add(BranchViewModel branchViewModel)
        {
            if (ModelState.IsValid)
            {
                var branch = _mapper.Map<Branch>(branchViewModel.Branch);

                var selectedUser = await _userManager.FindByIdAsync(branchViewModel.Branch.UserId);
                if (selectedUser != null)
                {
                    branch.User = selectedUser;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Wybrany użytkownik jest nieprawidłowy.");
                    return View(branchViewModel);
                }

                await _branchService.Add(branch);
                return RedirectToAction("All");
            }

            var usersWithRoles = await _userManager.GetUsersInRoleAsync("pracownik");
            usersWithRoles.AddRange(await _userManager.GetUsersInRoleAsync("admin"));

            branchViewModel.Users = usersWithRoles.Select(u => new SelectListItem { Value = u.Id, Text = u.Email }).ToList();
            return View(branchViewModel);
        }


        [Authorize(Roles = "admin")]
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
