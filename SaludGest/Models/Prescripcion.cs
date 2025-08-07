namespace SaludGest.Models
{
    public class Prescripcion : Registro
    {
        public int PrescripcionId { get; set; }
        public int HistorialMedicoId { get; set; }
        public int MedicamentoId { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public DateTime FechaPrescripcion { get; set; }
        public DateTime FechaFin { get; set; }
        public HistorialMedico HistorialMedico { get; set; }
        public Medicamento Medicamento { get; set; }
    }
}
