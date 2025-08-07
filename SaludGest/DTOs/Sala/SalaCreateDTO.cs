using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.Sala
{
    public class SalaCreateDTO : RegistroDTO
    {
        public int DepartamentoId { get; set; }
        public int NumeroSala { get; set; }
        public string TipoSala { get; set; }
    }
}
