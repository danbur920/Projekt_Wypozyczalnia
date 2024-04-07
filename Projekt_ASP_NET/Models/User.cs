using Microsoft.AspNetCore.Identity;

namespace Projekt_ASP_NET.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        //public string? Email { get; set; }
        //public string? Role { get; set; } // worker, admin
        public virtual List<Rental>? Rentals { get; set; }
        public virtual List<Reservation>? Reservations { get; set; }
        public virtual List<Branch>? Branches { get; set; } // pole nie jest null, gdy dany użytkownik zarządza danym oddziałem
    }
}
