using SaludGest.DTOs.Registro;
using System.ComponentModel.DataAnnotations;

namespace SaludGest.DTOs.Departamento
{
    public class DepartamentoCreateDTO : RegistroDTO
    {
        [Display(Name = "Nombre del Departamento")]
        public string NombreDepartamento { get; set; }
        [Display(Name = "Ubicación del Departamento")]
        public string Ubicacion { get; set; }
    }
}
