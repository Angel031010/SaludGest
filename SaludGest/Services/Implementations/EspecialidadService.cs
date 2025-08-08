using Microsoft.EntityFrameworkCore;
using SaludGest.Constans;
using SaludGest.Data;
using SaludGest.DTOs.Especialidad;
using SaludGest.Models;
using SaludGest.Services.Interfaces;

namespace SaludGest.Services.Implementations
{
    public class EspecialidadService : IEspecialidadService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EspecialidadService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<EspecialidadReadDTO>> GetAllAsync()
        {
            var especialidades = await _applicationDbContext.Especialidades
                .Where(e => !e.Eliminado)
                .Select(e => new EspecialidadReadDTO
                {
                    EspecialidadId = e.EspecialidadId,
                    NombreEspecialidad = e.NombreEspecialidad,
                    Descripcion = e.Descripcion
                }).ToListAsync();
            return especialidades;
        }

        public async Task<EspecialidadReadDTO> GetByIdAsync(int id)
        {
            var especialidad = await _applicationDbContext.Especialidades
                .Where(e => e.EspecialidadId == id && !e.Eliminado)
                .Select(e => new EspecialidadReadDTO
                {
                    EspecialidadId = e.EspecialidadId,
                    NombreEspecialidad = e.NombreEspecialidad,
                    Descripcion = e.Descripcion
                }).FirstOrDefaultAsync();

            if (especialidad == null)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.EspecialidadNoEncontradaID, id));
            }
            return especialidad;
        }

        public async Task AddAsync(EspecialidadCreateDTO createDto)
        {
            Especialidad especialidad = new Especialidad
            {
                NombreEspecialidad = createDto.NombreEspecialidad,
                Descripcion = createDto.Descripcion,
            };

            await _applicationDbContext.Especialidades.AddAsync(especialidad);
            await _applicationDbContext.SaveChangesAsync();

        }

        public async Task UpdateAsync(int id, EspecialidadCreateDTO updateDto)
        {
            if (id != updateDto.EspecialidadId)
            {
                throw new ApplicationException("El Id es incorrecto");
            }
            var especialidad = await _applicationDbContext.Especialidades
                .FindAsync(updateDto.EspecialidadId);

            if (especialidad == null || especialidad.Eliminado)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.EspecialidadNoEncontradaID, id));
            }

            especialidad.NombreEspecialidad = updateDto.NombreEspecialidad;
            especialidad.Descripcion = updateDto.Descripcion;
            _applicationDbContext.Especialidades.Update(especialidad);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var especialidad = await _applicationDbContext.Especialidades
                .FindAsync(id);
            if (especialidad == null || especialidad.Eliminado)
                {
                throw new KeyNotFoundException(string.Format(Messages.Error.EspecialidadNoEncontradaID, id));
            }
            especialidad.Eliminado = true;
            especialidad.Activo = false;
            _applicationDbContext.Especialidades.Update(especialidad);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
