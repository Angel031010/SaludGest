using SaludGest.DTOs.Registro;
using System.ComponentModel.DataAnnotations;
namespace SaludGest.DTOs.Especialidad
{
    public class EspecialidadReadDTO : RegistroDTO
    {
        public int EspecialidadId { get; set; }
        [Display(Name = "Nombre de Especialidad")]
        public string NombreEspecialidad { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}
