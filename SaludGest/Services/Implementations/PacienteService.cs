using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SaludGest.Constans;
using SaludGest.Data;
using SaludGest.DTOs.Paciente;
using SaludGest.Models;
using SaludGest.Services.Interfaces;
using SaludGest.Settings;

namespace SaludGest.Services.Implementations
{
    public class PacienteService : IPacienteService
    {

        private readonly ApplicationDbContext _ApplicationDbContext;
        private readonly UploadSettings _uploadSettings;
        private readonly IWebHostEnvironment _env;

        public PacienteService(ApplicationDbContext applicationDbContext,
            IOptions<UploadSettings> uploadSettings,
            IWebHostEnvironment web)
        {
            _ApplicationDbContext = applicationDbContext;
            _uploadSettings = uploadSettings.Value;
            _env= web;
        }

        public async Task<List<PacienteReadDTO>> GetAllAsync()
        {
            var pacientes = await _ApplicationDbContext.Pacientes
                .Where(p => !p.Eliminado)
                .Select(p => new PacienteReadDTO
                {
                    PacienteId = p.PacienteId,
                    Nombre = p.Nombre,
                    ApellidoPaterno = p.ApellidoPaterno,
                    ApellidoMaterno = p.ApellidoMaterno,
                    FechaNacimiento = p.FechaNacimiento,
                    Genero = p.Genero,
                    Telefono = p.Telefono,
                    Email = p.Email,
                    Direccion = p.Direccion,
                    NumeroSeguroSocial = p.NumeroSeguroSocial,
                    FotoUrl = p.FotoUrl
                }).ToListAsync();
            return pacientes;
        }

        public async Task<PacienteReadDTO> GetByIdAsync(int id)
        {
            var paciente = await _ApplicationDbContext.Pacientes
                .Where(p => p.PacienteId == id && p.Eliminado == false)
                .Select(p => new PacienteReadDTO
                {
                    PacienteId = p.PacienteId,
                    Nombre = p.Nombre,
                    ApellidoPaterno = p.ApellidoPaterno,
                    ApellidoMaterno = p.ApellidoMaterno,
                    FechaNacimiento = p.FechaNacimiento,
                    Genero = p.Genero,
                    Telefono = p.Telefono,
                    Email = p.Email,
                    Direccion = p.Direccion,
                    NumeroSeguroSocial = p.NumeroSeguroSocial,
                    FotoUrl = p.FotoUrl
                }).FirstOrDefaultAsync();
            if (paciente == null)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.PacienteNoEncontradoID, id));
            }
            return paciente;
        }

        public async Task AddAsync(PacienteCreateDTO createDto)
        {
            var urlfoto = await UploadImage(createDto.Foto);
            Paciente paciente = new Paciente
            {
                Nombre = createDto.Nombre,
                ApellidoPaterno = createDto.ApellidoPaterno,
                ApellidoMaterno = createDto.ApellidoMaterno,
                FechaNacimiento = createDto.FechaNacimiento,
                Genero = createDto.Genero,
                Telefono = createDto.Telefono,
                Email = createDto.Email,
                Direccion = createDto.Direccion,
                NumeroSeguroSocial = createDto.NumeroSeguroSocial,
                FotoUrl = urlfoto,
            };

            await _ApplicationDbContext.Pacientes.AddAsync(paciente);
            await _ApplicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, PacienteEditDTO updateDto)
        {
            if (id != updateDto.PacienteId)
            {
                throw new ApplicationException("El Id es incorrecto");
            }
            var paciente = await _ApplicationDbContext.Pacientes.FindAsync(updateDto.PacienteId);

            if (paciente == null || paciente.Eliminado)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.PacienteNoEncontradoID, id));
            }

            paciente.Nombre = updateDto.Nombre;
            paciente.ApellidoPaterno = updateDto.ApellidoPaterno;
            paciente.ApellidoMaterno = updateDto.ApellidoMaterno;
            paciente.FechaNacimiento = updateDto.FechaNacimiento;
            paciente.Genero = updateDto.Genero;
            paciente.Telefono = updateDto.Telefono;
            paciente.Email = updateDto.Email;
            paciente.Direccion = updateDto.Direccion;
            paciente.NumeroSeguroSocial = updateDto.NumeroSeguroSocial;

            _ApplicationDbContext.Pacientes.Update(paciente);
            await _ApplicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var paciente = await _ApplicationDbContext.Pacientes.FindAsync(id);
            if (paciente == null)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.PacienteNoEncontradoID, id));
            }
            paciente.Eliminado = true;
            paciente.Activo = false;
            _ApplicationDbContext.Pacientes.Update(paciente);
            await _ApplicationDbContext.SaveChangesAsync();
        }


        private async Task<string> UploadImage(IFormFile file)
        {
            ValidateFile(file);

            //string _customPath = Path.Combine(Directory.GetCurrentDirectory(), _uploadSettings.UploadDirectory);
            string _customPath = Path.Combine(_env.WebRootPath, _uploadSettings.UploadDirectory);

            if (!Directory.Exists(_customPath))   // Crear el directorio si no existe
            {
                Directory.CreateDirectory(_customPath);
            }

            // Generar el nombre único del archivo
            var fileName = Path.GetFileNameWithoutExtension(file.FileName)
                            + Guid.NewGuid().ToString()
                            + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(_customPath, fileName);

            // Guardar el archivo
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Retornar la ruta relativa o completa, según sea necesario
            return $"/{_uploadSettings.UploadDirectory}/{fileName}";
        }

        private void ValidateFile(IFormFile file)
        {
            var permittedExtensions = _uploadSettings.AllowedExtensions.Split(',');
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();

            if (!permittedExtensions.Contains(extension))
            {
                //throw new NotSupportedException("El tipo de archivo no es soportado.");
                throw new NotSupportedException(Messages.Validation.UnSupportedFileType);
            }
        }

    }
}
