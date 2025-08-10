using SaludGest.DTOs.Registro;
using System.ComponentModel.DataAnnotations;

namespace SaludGest.DTOs.Cita
{
    public class CitaReadDTO : RegistroDTO
    {
        public int CitaId { get; set; }
        [Display(Name = "Fecha y Hora")]
        public DateTime FechaHora { get; set; }

        [Display(Name = "Médico")]
        public int MedicoId { get; set; }

        [Display(Name = "Nombre del Médico")]
        public string NombreMedico { get; set; }

        [Display(Name = "Paciente")]
        public int PacienteId { get; set; }

        [Display(Name = "Nombre del Paciente")]
        public string NombrePaciente { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; }
    }
}
