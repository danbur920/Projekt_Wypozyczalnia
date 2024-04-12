using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP_NET.Models
{
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
