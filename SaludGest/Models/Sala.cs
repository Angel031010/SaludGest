namespace SaludGest.Models
{
    public class Sala : Registro
    {
        public int SalaId { get; set; }
        public int DepartamentoId { get; set; }
        public int NumeroSala { get; set; }
        public string TipoSala { get; set; } // "Consulta", "Emergencia", "Quirófano", "Examen", "Recuperación"
        
        public Departamento Departamento { get; set; }
    }
}
