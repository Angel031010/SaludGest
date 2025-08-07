using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.Medicamento
{
    public class MedicamentoReadDTO : RegistroDTO
    {
        public int MedicamentoId { get; set; }
        public string Nombre { get; set; }
    }
}
