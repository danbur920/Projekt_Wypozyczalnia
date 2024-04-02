using Microsoft.EntityFrameworkCore;
using Projekt_ASP_NET.Data;
using Projekt_ASP_NET.Models;
using Projekt_ASP_NET.Repository.Interfaces;

namespace Projekt_ASP_NET.Repository
{
    public class BranchRepository : IRepository<Branch>
    {
        private readonly ApplicationDbContext _context;

        public BranchRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Branch> GetById(int id)
        {
            return await _context.Branches.FindAsync(id);
        }

        public async Task<IEnumerable<Branch>> GetAll()
        {
            return await _context.Branches.ToListAsync();
        }


        public async Task Add(Branch branch)
        {
            _context.Branches.Add(branch);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Branch branch)
        {
            _context.Entry(branch).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var branchToDelete = await _context.Branches.FindAsync(id);

            if (branchToDelete != null)
            {
                _context.Branches.Remove(branchToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
