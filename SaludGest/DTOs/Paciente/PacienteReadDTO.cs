using SaludGest.DTOs.Registro;
using System.ComponentModel.DataAnnotations;

namespace SaludGest.DTOs.Paciente
{
    public class PacienteReadDTO : RegistroDTO
    {
        [Display(Name = "ID Paciente")]
        public int PacienteId { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Género")]
        public string Genero { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Correo Electrónico")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "No. Seguro Social")]
        public string NumeroSeguroSocial { get; set; }

        [Display(Name = "Foto URL")]
        public string? FotoUrl { get; set; }
    }
}
