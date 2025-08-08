using SaludGest.DTOs.Registro;
using System.ComponentModel.DataAnnotations;

namespace SaludGest.DTOs.Paciente
{
    public class PacienteEditDTO : RegistroDTO
    {
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido Paterno es obligatorio.")]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "El campo Apellido Materno es obligatorio.")]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio.")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo Género es obligatorio.")]
        [Display(Name = "Género")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es obligatorio.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo Correo Electrónico es obligatorio.")]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Dirección es obligatorio.")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo No. Seguro Social es obligatorio.")]
        [Display(Name = "No. Seguro Social")]
        public string NumeroSeguroSocial { get; set; }
    }
}
