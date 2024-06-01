using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt_ASP_NET.Areas.Operator.ViewModels;
using Projekt_ASP_NET.Data;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Areas.Operator.Controllers
{
    [Area("Operator")]
    [Authorize(Policy = "AdminOrOperator")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;   
        private readonly UserManager<User> _userManager;   
        private readonly IMapper _mapper;

        public HomeController(ApplicationDbContext context, IMapper mapper, UserManager<User> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task <IActionResult> Index()
        {
            var rentals = await _context.Rentals.ToListAsync();
            var reservations = await _context.Reservations.ToListAsync();
            var vehicles = await _context.Vehicles.ToListAsync();
            var users = await _userManager.Users.ToListAsync();

            var viewModel = new RentalsViewModel
            {
                Rentals = rentals,
                Reservations = reservations,
                Vehicles = vehicles,
                Users = users
            };

            return View(viewModel);
        }
    }
}
