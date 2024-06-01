using Microsoft.AspNetCore.Identity;

namespace Rentals.Areas.Admin.Models
{
    public class ManageUserRolesViewModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public IList<string> AssignedRoles { get; set; } = new List<string>();
    }
}
