using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP_NET.ViewModels
{
    public class RegisterViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Nieprawidłowy email.")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string? Locality { get; set; }
        public string? Street { get; set; }
        public string? StreetNumber { get; set; }
        public string? UserType { get; set; }
    }
}
