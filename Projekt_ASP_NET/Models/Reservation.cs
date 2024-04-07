namespace Projekt_ASP_NET.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime? StartOfRental { get; set; }
        public DateTime? EndOfRental { get; set; }
        public int? VehicleId { get; set; }
        public int? UserId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public virtual Rental? Rental { get; set; }
        public virtual User? User { get; set; }
    }
}
