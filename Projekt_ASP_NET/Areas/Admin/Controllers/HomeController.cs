using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt_ASP_NET.Areas.Admin.ViewModels;
using Projekt_ASP_NET.Data;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.ViewModels;
using System.Security.Claims;

namespace Projekt_ASP_NET.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _singInManager;
        private readonly IMapper _mapper;

        public HomeController(UserManager<User> userManager, SignInManager<User> singInManager, IMapper mapper)
        {
            _userManager = userManager;
            _singInManager = singInManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userViewModel = _mapper.Map<IEnumerable<EditUserViewModel>>(users);

            foreach (var user in userViewModel)
            {
                var foundUser = users.
                    Where(x => x.Id == user.Id).
                    FirstOrDefault();

                var userRole = _userManager.
                    GetRolesAsync(foundUser).
                    Result.FirstOrDefault().
                    ToUpper();

                user.UserRole = userRole;
            }
            var sortedUserViewModel = userViewModel.OrderBy(u => u.UserRole);

            return View(sortedUserViewModel);
        }
    }
}
