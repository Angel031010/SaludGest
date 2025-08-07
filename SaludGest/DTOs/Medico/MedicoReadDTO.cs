using SaludGest.DTOs.Registro;
using System.ComponentModel.DataAnnotations;

namespace SaludGest.DTOs.Medico
{
    public class MedicoReadDTO : RegistroDTO
    {
        public int MedicoId { get; set; }
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }

        [Display(Name = "ID de Especialidad")]
        public int EspecialidadId { get; set; }

        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Display(Name = "ID de Departamento")]
        public int DepartamentoId { get; set; }

        [Display(Name = "Especialidad")]
        public string EspecialidadNombre { get; set; }

        [Display(Name = "Departamento")]
        public string DepartamentoNombre { get; set; }

    }
}
