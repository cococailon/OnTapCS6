using Shared;

namespace API.Repositories
{
    public interface ISinhVienRepo
    {
        Task<List<SinhVien>> GetAll();
        Task<SinhVien> GetByID(Guid id);
        Task Create(SinhVien sv);
        Task Update(SinhVien sv);
        Task Delete(Guid id);
    }
}
