using Microsoft.EntityFrameworkCore;
using SaludGest.Constans;
using SaludGest.Data;
using SaludGest.DTOs.Cita;
using SaludGest.Models;
using SaludGest.Services.Interfaces;

namespace SaludGest.Services.Implementations
{
    public class CitaService : ICitaService
    {
        private readonly ApplicationDbContext _context;
        public CitaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CitaReadDTO>> GetAllAsync()
        {
            var citas = await _context.Citas
                .Where(c => !c.Eliminado)
                .Select(c => new CitaReadDTO
                {
                    CitaId = c.CitaId,
                    FechaHora = c.FechaHora,
                    MedicoId = c.MedicoId,
                    NombreMedico = c.Medico.Nombre,
                    PacienteId = c.PacienteId,
                    NombrePaciente = c.Paciente.Nombre,
                    Estado = c.Estado,
                    Observaciones = c.Observaciones
                })
                .ToListAsync();
            return citas;
        }

        public async Task<CitaReadDTO> GetByIdAsync(int id)
        {
            var cita = await _context.Citas
                .Where(c => c.CitaId == id && !c.Eliminado)
                .Select(c => new CitaReadDTO
                {
                    CitaId = c.CitaId,
                    FechaHora = c.FechaHora,
                    MedicoId = c.MedicoId,
                    NombreMedico = c.Medico.Nombre,
                    PacienteId = c.PacienteId,
                    NombrePaciente = c.Paciente.Nombre,
                    Estado = c.Estado,
                    Observaciones = c.Observaciones
                })
                .FirstOrDefaultAsync();
            if (cita == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.CitaNoEncontradaID, id));
            return cita;
        }

        public async Task AddAsync(CitaCreateDTO createDto)
        {
            Cita cita = new Cita
            {
                CitaId = createDto.CitaId,
                FechaHora = createDto.FechaHora,
                MedicoId = createDto.MedicoId,
                PacienteId = createDto.PacienteId,
                Estado = createDto.Estado,
                Observaciones = createDto.Observaciones,
            };

            await _context.Citas.AddAsync(cita);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, CitaReadDTO updateDto)
        {
            if (id != updateDto.CitaId)
            {
                throw new ApplicationException("Id Incorrecto");
            }
            var cita = await _context.Citas.FindAsync(id);
            if (cita == null || cita.Eliminado)
                {
                throw new KeyNotFoundException(string.Format(Messages.Error.CitaNoEncontradaID, id));
            }

            cita.FechaHora = updateDto.FechaHora;
            cita.MedicoId = updateDto.MedicoId;
            cita.PacienteId = updateDto.PacienteId;
            cita.Estado = updateDto.Estado;
            cita.Observaciones = updateDto.Observaciones;
            _context.Citas.Update(cita);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cita = await _context.Citas
                .FindAsync(id);
            if (cita == null || cita.Eliminado)
                {
                throw new KeyNotFoundException(string.Format(Messages.Error.CitaNoEncontradaID, id));
            }
            cita.Eliminado = true;
            cita.Activo = false;

            _context.Citas.Update(cita);
            await _context.SaveChangesAsync();
        }

        public Task UpdateAsync(int id, CitaCreateDTO updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
