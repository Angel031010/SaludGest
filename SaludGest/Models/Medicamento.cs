namespace SaludGest.Models
{
    public class Medicamento : Registro
    {
        public int MedicamentoId { get; set; }
        public string Nombre { get; set; }
        public string Laboratorio { get; set; }
        public string Presentacion { get; set; }

        public IEnumerable<Prescripcion> Prescripciones { get; set; }
    }
}
