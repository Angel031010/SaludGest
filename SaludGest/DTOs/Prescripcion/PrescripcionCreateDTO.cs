using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.Prescripcion
{
    public class PrescripcionCreateDTO : RegistroDTO
    {
        public int HistorialMedicoId { get; set; }
        public int MedicamentoId { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public DateTime FechaPrescripcion { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
