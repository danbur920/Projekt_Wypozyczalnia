using Microsoft.EntityFrameworkCore;
using Projekt_ASP_NET.Data;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Repository.Interfaces;

namespace Projekt_ASP_NET.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly RentalSystemDbContext _context;

        public VehicleRepository(RentalSystemDbContext context)
        {
            _context = context;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _context.Add(vehicle);
            _context.SaveChanges();
        }

        public void DeleteVehicle(int id)
        {
            var vehicleToDelete = _context.Vehicles.Where(x=>x.Id==id).FirstOrDefault();
            _context.Remove(vehicleToDelete);
            _context.SaveChanges();
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            return _context.Vehicles.ToList();
        }

        public Vehicle GetVehicleById(int id)
        {
            return _context.Vehicles.Find(id);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _context.Entry(vehicle).State = EntityState.Modified;
            _context.SaveChanges();
        }

    }
}
