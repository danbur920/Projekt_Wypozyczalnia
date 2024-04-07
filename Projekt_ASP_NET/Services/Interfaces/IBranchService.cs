using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Services.Interfaces
{
    public interface IBranchService
    {
        Task<Branch> GetById(int id);
        Task<IEnumerable<Branch>> GetAll();
        Task Add(Branch item);
        Task Update(Branch item);
        Task Delete(int id);
    }
}
