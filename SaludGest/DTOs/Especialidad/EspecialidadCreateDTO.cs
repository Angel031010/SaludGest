using SaludGest.DTOs.Registro;
using System.ComponentModel.DataAnnotations;

namespace SaludGest.DTOs.Especialidad
{
    public class EspecialidadCreateDTO : RegistroDTO
    {
        public int EspecialidadId { get; set; }
        [Required(ErrorMessage = "El nombre de la especialidad es obligatorio.")]
        [Display(Name = "Nombre de Especialidad")]
        public string NombreEspecialidad { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }

}
