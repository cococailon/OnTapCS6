using API.Context;
using Microsoft.EntityFrameworkCore;
using Shared;

namespace API.Repositories
{
    public class SinhVienRepo : ISinhVienRepo
    {
        private readonly AppDbContext _dbContext;
        public SinhVienRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(SinhVien sv)
        {
            _dbContext.sinhViens.Add(sv);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var sv = _dbContext.sinhViens.Find(id);
            if (sv != null)
            {
                _dbContext.sinhViens.Remove(sv);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<SinhVien>> GetAll()
        {
            return await _dbContext.sinhViens.ToListAsync();
        }

        public async Task<SinhVien> GetByID(Guid id)
        {
            return await _dbContext.sinhViens.FindAsync(id);
        }

        public async Task Update(SinhVien sv)
        {
            _dbContext.sinhViens.Update(sv);
            await _dbContext.SaveChangesAsync();
        }
    }
}
