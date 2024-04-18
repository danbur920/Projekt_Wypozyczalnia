using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Repository;
using Projekt_ASP_NET.Repository.Interfaces;
using Projekt_ASP_NET.Services.Interfaces;

namespace Projekt_ASP_NET.Services
{
    public class BranchService : IBranchService
    {
        private readonly IRepository<Branch> _branchRepository;
        public BranchService(IRepository<Branch> branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public async Task Add(Branch item)
        {
            await _branchRepository.Add(item);
        }

        public async Task Delete(int id)
        {
            await _branchRepository.Delete(id);
        }

        public async Task<IEnumerable<Branch>> GetAll()
        {
            return await _branchRepository.GetAll();
        }

        public async Task<Branch> GetById(int id)
        {
            return await _branchRepository.GetById(id);
        }

        public async Task Update(Branch item)
        {
            await _branchRepository.Update(item);
        }
    }
}


