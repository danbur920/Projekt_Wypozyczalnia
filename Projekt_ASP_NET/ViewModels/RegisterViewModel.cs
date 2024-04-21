using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP_NET.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Nieprawidłowy email.")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
