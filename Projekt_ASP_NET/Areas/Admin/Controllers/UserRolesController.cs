using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rentals.Areas.Admin.Models;
using Rentals.Models;

namespace Rentals.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserRolesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRolesController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: /Admin/UserRoles/Index
        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users;
            var userRoleViewModels = new List<UserRoleViewModel>();

            foreach (var user in users)
            {
                var thisViewModel = new UserRoleViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.Roles = await _userManager.GetRolesAsync(user);
                userRoleViewModels.Add(thisViewModel);
            }

            return View(userRoleViewModels);
        }

        // GET: /Admin/UserRoles/Manage
        public async Task<IActionResult> Manage(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound();
            }

            var model = new ManageUserRolesViewModel
            {
                UserId = user.Id,
                Email = user.Email,
                Roles = await _roleManager.Roles.ToListAsync()
            };

            foreach (var role in model.Roles)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.AssignedRoles.Add(role.Name);
                }
            }

            return View(model);
        }

        // POST: /Admin/UserRoles/Manage
        [HttpPost]
        public async Task<IActionResult> Manage(ManageUserRolesViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);

            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var selectedRoles = model.AssignedRoles ?? new List<string>();

            var result = await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Nie udało się dodać ról");
                return View(model);
            }

            result = await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Nie udało się usunąć ról");
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
