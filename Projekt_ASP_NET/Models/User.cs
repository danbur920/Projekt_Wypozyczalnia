using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP_NET.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "Imię")]
        public string? FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string? LastName { get; set; }
        [Display(Name = "Miejscowość")]
        public string? Locality { get; set; }
        [Display(Name = "Ulica")]
        public string? Street { get; set; }
        [Display(Name = "Numer domu")]
        public string? StreetNumber { get; set; }
        [Display(Name = "Rodzaj użytkownika")]
        public string? UserType { get; set; }
        public virtual List<Rental>? Rentals { get; set; }
        public virtual List<Reservation>? Reservations { get; set; }
        public virtual List<Branch>? Branches { get; set; }
    }
}

