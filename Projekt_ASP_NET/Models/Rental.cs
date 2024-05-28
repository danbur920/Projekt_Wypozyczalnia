using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP_NET.Models
{
    public class Rental
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
        [Required]
        public string? UserId { get; set; }
        [Required]
        public int? ReservationId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public virtual Reservation? Reservation { get; set; }
        public virtual User? User { get; set; }
    }
}
