using SaludGest.DTOs.Registro;
using System.ComponentModel.DataAnnotations;

namespace SaludGest.DTOs.Cita
{
    public class CitaCreateDTO : RegistroDTO
    {
        public int CitaId { get; set; }
        [Required(ErrorMessage = "La fecha y hora de la cita son obligatorias.")]
        [Display(Name = "Fecha y Hora")]
        public DateTime FechaHora { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un médico.")]
        [Display(Name = "Médico")]
        public int MedicoId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un paciente.")]
        [Display(Name = "Paciente")]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "El estado de la cita es obligatorio.")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese las observaciones.")]
        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; }
    }
}
