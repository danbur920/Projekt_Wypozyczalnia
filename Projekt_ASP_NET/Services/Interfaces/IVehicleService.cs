using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Repository.Interfaces;

namespace Projekt_ASP_NET.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<Vehicle> GetById(int id);
        Task<IEnumerable<Vehicle>> GetAll();
        Task Add(Vehicle item);
        Task Update(Vehicle item);
        Task Delete(int id);
    }
}
