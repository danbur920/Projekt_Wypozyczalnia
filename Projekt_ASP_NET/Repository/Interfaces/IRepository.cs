using Projekt_ASP_NET.Models;

namespace Projekt_ASP_NET.Repository.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T item);
        Task Update(T item);
        Task Delete(int id);
    }
}
