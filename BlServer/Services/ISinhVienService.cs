using Shared;

namespace BlServer.Services
{
    public interface ISinhVienService
    {
        Task<List<SinhVien>> GetAll();
        Task<SinhVien> GetByID(Guid id);
        Task Create(SinhVien sv);
        Task Update(SinhVien sv);
        Task Delete(Guid id);
    }
}
