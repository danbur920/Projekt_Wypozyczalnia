using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Repository.Interfaces
{
    public interface IVehicleRepository
    {
        Vehicle GetVehicleById(int id);
        IEnumerable<Vehicle> GetAllVehicles();
        void AddVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(int id);
    }
}
