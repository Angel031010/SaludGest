using System.ComponentModel.DataAnnotations.Schema;

namespace SaludGest.Models
{
    public class Factura : Registro
    {
        public int FacturaId { get; set; }
        public int PacienteId { get; set; }
        public DateTime FechaEmision { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal MontoTotal { get; set; }
        public string Estado { get; set; } // Ejemplo: "Pagada", "Pendiente", "Cancelada"

        public Paciente Paciente { get; set; }
    }
}
