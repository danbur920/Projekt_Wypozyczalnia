//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Projekt_ASP_NET.Models;
//using Projekt_ASP_NET.ViewModels;
//using System.Security.Claims;

//namespace Projekt_ASP_NET.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly UserManager<User> _userManager;
//        private readonly SignInManager<User> _singInManager;
//        private readonly IMapper _mapper;

//        public AccountController(UserManager<User> userManager, SignInManager<User> singInManager, IMapper mapper)
//        {
//            _userManager = userManager;
//            _singInManager = singInManager;
//            _mapper = mapper;
//        }

//        [HttpGet] 
//        public IActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Login(LoginViewModel userLogin)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(userLogin);
//            }

//            var user = _mapper.Map<User>(userLogin);
//            await _singInManager.PasswordSignInAsync(user.UserName, user.PasswordHash, false, false);
//            return RedirectToAction("Index", "Home");
//        }

//        [HttpGet]
//        public IActionResult Register()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Register(RegisterViewModel userRegister)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(userRegister);
//            }

//            var user = _mapper.Map<User>(userRegister);

//            var result = await _userManager.CreateAsync(user, userRegister.Password);

//            if (result.Succeeded)
//            {
//                await _userManager.AddToRoleAsync(user, "klient");
//                return RedirectToAction("Index", "Home");
//            }
//            else
//            {
//                foreach (var error in result.Errors)
//                {
//                    ModelState.AddModelError(string.Empty, error.Description);
//                }
//                return View(userRegister);
//            }
//        }

//        public async Task<IActionResult> LogOut()
//        {
//            await _singInManager.SignOutAsync();
//            return RedirectToAction("Index", "Home");
//        }
//        public IActionResult AccessDenied()
//        {
//            return View();
//        }

//        //[HttpGet]
//        //public async Task<IActionResult> Edit()
//        //{
//        //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
//        //    var user = await _userManager.FindByIdAsync(userId);
//        //    if (user == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var model = _mapper.Map<EditUserViewModel>(user);
//        //    return View(model);
//        //}

//        //[HttpPost]
//        //public async Task<IActionResult> Edit(EditUserViewModel model)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        var user = await _userManager.FindByIdAsync(model.Id);
//        //        if (user == null)
//        //        {
//        //            return NotFound();
//        //        }

//        //        var editUser = _mapper.Map<User>(user);

//        //        var result = await _userManager.UpdateAsync(editUser);
//        //        if (result.Succeeded)
//        //        {
//        //            return RedirectToAction("Index", "Home");
//        //        }
//        //    }

//        //    return View(model);
//        //}
//    }
//}
