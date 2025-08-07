using System.ComponentModel.DataAnnotations;

namespace SaludGest.DTOs.Registro
{
    public class RegistroDTO
    {
        [Display(Name = "Estatus")]
        public bool Activo { get; set; } = true;
        //public bool Eliminado { get; set; } = false;

        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
