using Rentals.Models;
using System.ComponentModel.DataAnnotations;

namespace Rentals.Areas.Admin.Models
{
    public class CreateUserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<string> SelectedRoles { get; set; } = new List<string>();
        public UserClass UserClass { get; set; }
    }
}
