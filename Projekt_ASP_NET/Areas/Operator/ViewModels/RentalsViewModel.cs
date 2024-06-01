using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Areas.Operator.ViewModels
{
    public class RentalsViewModel
    {
        public IEnumerable<User> Users { get; set; } = Enumerable.Empty<User>();
        public IEnumerable<Rental> Rentals { get; set; } = Enumerable.Empty<Rental>();
        public IEnumerable<Reservation> Reservations { get; set; } = Enumerable.Empty<Reservation>();
        public IEnumerable<Vehicle> Vehicles { get; set; } = Enumerable.Empty<Vehicle>();

    }
}
