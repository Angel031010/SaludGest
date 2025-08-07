using Microsoft.EntityFrameworkCore;
using SaludGest.Constans;
using SaludGest.Data;
using SaludGest.DTOs.Medico;
using SaludGest.Models;
using SaludGest.Services.Interfaces;

namespace SaludGest.Services.Implementations
{
    public class MedicoService : IMedicoService
    {

        private readonly ApplicationDbContext _context;
        public MedicoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<MedicoReadDTO>> GetAllAsync()
        {
            var medicos = await _context.Medicos
                .Where(m => !m.Eliminado)
                .Select(m => new MedicoReadDTO
                {
                    MedicoId = m.MedicoId,
                    Nombre= m.Nombre,
                    ApellidoPaterno = m.ApellidoPaterno,
                    ApellidoMaterno = m.ApellidoMaterno,
                    EspecialidadId = m.EspecialidadId,
                    Email = m.Email,
                    DepartamentoId = m.DepartamentoId,
                    EspecialidadNombre = m.Especialidad.NombreEspecialidad,
                    DepartamentoNombre = m.Departamento.NombreDepartamento,
                    FechaCreacion = m.FechaCreacion
                }).ToListAsync();
            return medicos;
        }

        public async Task<MedicoReadDTO> GetByIdAsync(int id)
        {
            var medico = await _context.Medicos
                .Where(m => m.MedicoId == id && !m.Eliminado)
                .Select(m => new MedicoReadDTO
                {
                    MedicoId = m.MedicoId,
                    Nombre = m.Nombre,
                    ApellidoPaterno = m.ApellidoPaterno,
                    ApellidoMaterno = m.ApellidoMaterno,
                    EspecialidadId = m.EspecialidadId,
                    Email = m.Email,
                    DepartamentoId = m.DepartamentoId,
                    EspecialidadNombre = m.Especialidad.NombreEspecialidad,
                    DepartamentoNombre = m.Departamento.NombreDepartamento,
                    FechaCreacion = m.FechaCreacion
                }).FirstOrDefaultAsync();
            if (medico == null)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.MedicoNoEncontradoID, id));
            }
            return medico;
        }

        public async Task AddAsync(MedicoCreateDTO createDto)
        {
            Medico medico = new Medico
            {
                Nombre = createDto.Nombre,
                ApellidoPaterno = createDto.ApellidoPaterno,
                ApellidoMaterno = createDto.ApellidoMaterno,
                EspecialidadId = createDto.EspecialidadId,
                Telefono = createDto.Telefono,
                Email = createDto.Email,
                DepartamentoId = createDto.DepartamentoId
            };

            await _context.Medicos.AddAsync(medico);
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateAsync(int id, MedicoCreateDTO updateDto)
        {
            if (id != updateDto.MedicoId)
            {
                throw new ApplicationException("Id Incorrecto");
            }
            var medico = await _context.Medicos.FindAsync(id);
            if (medico == null || medico.Eliminado)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.MedicoNoEncontradoID, id));
            }

            medico.Nombre = updateDto.Nombre;
            medico.ApellidoPaterno = updateDto.ApellidoPaterno;
            medico.ApellidoMaterno = updateDto.ApellidoMaterno;
            medico.EspecialidadId = updateDto.EspecialidadId;
            medico.Telefono = updateDto.Telefono;
            medico.Email = updateDto.Email;
            medico.DepartamentoId = updateDto.DepartamentoId;
            _context.Medicos.Update(medico);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var medico = await _context.Medicos.FindAsync(id);
            if (medico == null || medico.Eliminado)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.MedicoNoEncontradoID, id));
            }
            medico.Eliminado = true;
            medico.Activo = false;
            _context.Medicos.Update(medico);
            await _context.SaveChangesAsync();
        }
    }
}
