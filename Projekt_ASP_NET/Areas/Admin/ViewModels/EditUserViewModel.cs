using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt_ASP_NET.Areas.Admin.ViewModels
{
    public class EditUserViewModel
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Locality { get; set; }
        public string? Street { get; set; }
        public string? StreetNumber { get; set; }
        public string? UserType { get; set; }
        public bool EmailConfirmed { get; set; }

        // Blokada:
        public bool IsBlockingUser { get; set; } = false;
        public DateTimeOffset? LockoutEnd { get; set; }

        // Zmiana hasła:
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }

        // Rola:
        public string? UserRole { get; set; }
    }
}
