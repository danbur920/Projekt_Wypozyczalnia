using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Projekt_ASP_NET.Areas.Admin.ViewModels;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<EditUserViewModel>(user);
            model.UserRole = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

            if(model.LockoutEnd.HasValue)
                model.IsBlockingUser = true;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);

                if (user == null)
                    return NotFound();

                if (model.Password != model.ConfirmPassword)
                {
                    ModelState.AddModelError("ConfirmPassword", "Potwierdzenie hasła nie zgadza się z nowym hasłem.");
                    return View(model);
                }

                if (model.IsBlockingUser)
                {
                    DateTimeOffset value = DateTimeOffset.UtcNow.AddYears(100);
                    model.LockoutEnd = value;
                }
                else
                    model.LockoutEnd = null;
                    
                _mapper.Map(model, user);

                var checkRole = await _userManager.IsInRoleAsync(user, model.UserRole);

                if (!checkRole)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    await _userManager.RemoveFromRolesAsync(user, roles);

                    await _userManager.AddToRoleAsync(user, model.UserRole);
                }
                    

                if (!string.IsNullOrEmpty(model.Password))
                {
                    var passwordHasher = new PasswordHasher<User>();
                    string hashedNewPassword = passwordHasher.HashPassword(null, model.Password);
                    user.PasswordHash = hashedNewPassword;
                }

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    TempData["SuccessMessage"] = "Zaktualizowano pomyślnie!";
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }
    }
}
