using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.Prescripcion
{
    public class PrescripcionReadDTO : RegistroDTO
    {
        public int PrescripcionId { get; set; }
        public string Medicamento { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public DateTime FechaPrescripcion { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
