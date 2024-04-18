using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.ViewModels
{
    public class VehicleShowViewModel
    {
        public List<Vehicle>? Vehicles { get; set; }
        public List<Branch>? Branches { get; set; }
    }
}

