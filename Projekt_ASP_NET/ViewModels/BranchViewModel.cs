using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.ViewModels
{
    public class BranchViewModel
    {
        public Branch? Branch { get; set; }
        public List<SelectListItem>? Users { get; set; }
    }
}
