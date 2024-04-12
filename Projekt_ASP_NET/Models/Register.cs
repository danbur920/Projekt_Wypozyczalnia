using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP_NET.Models
{
    public class Register
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
