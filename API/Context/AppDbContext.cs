using Microsoft.EntityFrameworkCore;
using Shared;

namespace API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<SinhVien> sinhViens { get; set; }
    }
}
