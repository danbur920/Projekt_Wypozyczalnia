namespace Projekt_ASP_NET.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime? StartOfRental { get; set; }
        public DateTime? EndOfRental { get; set; }
        public decimal? CenaWypozyczenia { get; set; }
        public int? VehicleId { get; set; }
        public int? UserId { get; set; }
        public int? ReservationId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public virtual Reservation? Reservation { get; set; }
        public virtual User? User { get; set; }
    }
}
