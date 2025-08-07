using SaludGest.DTOs.Registro;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace SaludGest.DTOs.Paciente
{
    public class PacienteCreateDTO : RegistroDTO
    {
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
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
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

        [Display(Name = "Foto del Paciente")]
        public IFormFile? Foto { get; set; } // Para subir la foto
    }
}
