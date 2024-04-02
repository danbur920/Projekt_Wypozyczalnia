using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Repository;
using Projekt_ASP_NET.Repository.Interfaces;
using Projekt_ASP_NET.Services.Interfaces;

namespace Projekt_ASP_NET.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepository<Vehicle> _vehicleRepository;
        public VehicleService(IRepository<Vehicle> vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task Add(Vehicle item)
        {
            await _vehicleRepository.Add(item);
        }

        public async Task Delete(int id)
        {
            await _vehicleRepository.Delete(id);
        }

        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            return await _vehicleRepository.GetAll();
        }

        public async Task<Vehicle> GetById(int id)
        {
            return await _vehicleRepository.GetById(id);
        }

        public async Task Update(Vehicle item)
        {
            await _vehicleRepository.Update(item);
        }
    }
}
