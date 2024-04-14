using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.ViewModels
{
    public class VehicleViewModel
    {
        public Vehicle? Vehicle { get; set; }
        public List<SelectListItem>? Branches { get; set; }
    }
}
