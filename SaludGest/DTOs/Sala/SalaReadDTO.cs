using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.Sala
{
    public class SalaReadDTO : RegistroDTO
    {
        public int SalaId { get; set; }
        public int NumeroSala { get; set; }
        public string TipoSala { get; set; }
        public string NombreDepartamento { get; set; }
    }
}
