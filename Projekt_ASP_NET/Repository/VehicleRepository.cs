using Microsoft.EntityFrameworkCore;
using Projekt_ASP_NET.Data;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Repository.Interfaces;

namespace Projekt_ASP_NET.Repository
{
    public class VehicleRepository : IRepository<Vehicle>
    {
        private readonly ApplicationDbContext _context;

        public VehicleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Vehicle> GetById(int id)
        {
            return await _context.Vehicles.FindAsync(id);
        }

        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            return await _context.Vehicles.ToListAsync();
        }


        public async Task Add(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Vehicle vehicle)
        {
            _context.Entry(vehicle).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var vehicleToDelete = await _context.Vehicles.FindAsync(id);

            if(vehicleToDelete != null)
            {
                _context.Vehicles.Remove(vehicleToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
