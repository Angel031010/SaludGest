using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.Factura
{
    public class FacturaCreateDTO : RegistroDTO
    {
        public int PacienteId { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal MontoTotal { get; set; }
        public string Estado { get; set; }
    }
}
