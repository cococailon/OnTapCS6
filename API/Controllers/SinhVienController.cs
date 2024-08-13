using API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly ISinhVienRepo _sinhVienRepo;

        public SinhVienController(ISinhVienRepo sinhVienRepo)
        {
            _sinhVienRepo = sinhVienRepo;
        }

        [HttpPost]
        public async Task Create(SinhVien sv)
        {
            await _sinhVienRepo.Create(sv);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _sinhVienRepo.Delete(id);
        }

        [HttpGet]
        public async Task<List<SinhVien>> GetAll()
        {
            return await _sinhVienRepo.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<SinhVien> GetByID(Guid id)
        {
            return await _sinhVienRepo.GetByID(id);
        }

        [HttpPut]
        public async Task Update(SinhVien sv)
        {
            await _sinhVienRepo.Update(sv);
        }
    }
}
