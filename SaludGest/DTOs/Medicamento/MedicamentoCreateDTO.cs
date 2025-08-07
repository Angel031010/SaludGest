using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.Medicamento
{
    public class MedicamentoCreateDTO : RegistroDTO
    {
        public string Nombre { get; set; }
        public string Laboratorio { get; set; }
        public string Presentacion { get; set; }
    }
}
