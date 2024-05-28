using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP_NET.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public DateTime? StartOfRental { get; set; }
        [Required]
        public DateTime? EndOfRental { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public int? VehicleId { get; set; }
        public string? UserId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public virtual Rental? Rental { get; set; }
        public virtual User? User { get; set; }
    }
}
