using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP_NET.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
