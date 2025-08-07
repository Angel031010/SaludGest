namespace SaludGest.Models
{
    public class HistorialMedico : Registro
    {
        public int HistorialMedicoId { set; get; }
        public int PacienteId { set; get; }
        public DateTime FechaRegistro { set; get; }
        public string Diagnostico { set; get; }
        public string Notas { set; get; }
        public Paciente Paciente { set; get; }

        public IEnumerable<Prescripcion> Prescripciones { set; get; }
    }
}
