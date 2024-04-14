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

        public BranchController(IBranchService branchService, UserManager<User> userManager)
        {
            _branchService = branchService;
            _userManager = userManager;
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var usersWithRoles = await _userManager.GetUsersInRoleAsync("pracownik");
            usersWithRoles.AddRange(await _userManager.GetUsersInRoleAsync("admin"));

            var viewModel = new BranchViewModel
            {
                Branch = new Branch(),
                Users = usersWithRoles.Select(u => new SelectListItem { Value = u.Id, Text = u.Email }).ToList()
            };

            return View(viewModel);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> Add(Branch branch)
        {
            var usersWithRoles = await _userManager.GetUsersInRoleAsync("pracownik");
            usersWithRoles.AddRange(await _userManager.GetUsersInRoleAsync("admin"));

            if (ModelState.IsValid)
            {
                if(!string.IsNullOrEmpty(branch.UserId))
                {
                    var selectedUser = usersWithRoles.FirstOrDefault(u => u.Id == branch.UserId);
                    if(selectedUser != null)
                    {
                        branch.User = selectedUser;
                        branch.UserId = selectedUser.Id;
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Wybrany użytkownik jest nieprawidłowy.");
                        return View(branch);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Proszę wybrać użytkownika.");
                    return View(branch);
                }

                await _branchService.Add(branch);
                return RedirectToAction("All");
            }
            return View(branch);
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
