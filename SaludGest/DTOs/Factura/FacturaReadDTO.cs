using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.Factura
{
    public class FacturaReadDTO : RegistroDTO
    {
        public int FacturaId { get; set; }
        public string NombrePaciente { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal MontoTotal { get; set; }
        public string Estado { get; set; }
    }
}
