using Microsoft.EntityFrameworkCore;
using SaludGest.Data;
using SaludGest.DTOs.Departamento;
using SaludGest.Services.Interfaces;

namespace SaludGest.Services.Implementations
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly ApplicationDbContext _context;

        public DepartamentoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<DepartamentoReadDTO>> GetAllAsync()
        {
            var departamentos = await _context.Departamentos
                .Where(d => !d.Eliminado)
                .Select(d => new DepartamentoReadDTO
                {
                    DepartamentoId = d.DepartamentoId,
                    NombreDepartamento = d.NombreDepartamento,
                    Ubicacion = d.Ubicacion,
                }).ToListAsync();
            return departamentos;
        }

        public Task AddAsync(DepartamentoCreateDTO createDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DepartamentoReadDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, DepartamentoCreateDTO updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
