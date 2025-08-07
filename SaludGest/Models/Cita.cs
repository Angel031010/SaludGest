namespace SaludGest.Models
{
    public class Cita : Registro
    {
        public int CitaId { get; set; }
        public DateTime FechaHora { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public string Estado { get; set; } // Ejemplo: "Programada", "Completada", "Cancelada"
        public string Observaciones { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
    }
}
