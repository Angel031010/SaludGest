namespace SaludGest.Models
{
    public class Departamento : Registro
    {
        public int DepartamentoId { get; set; }
        public string NombreDepartamento { get; set; }
        public string Ubicacion { get; set; }

        public IEnumerable<Medico> Medicos { get; set; }
        public IEnumerable<Sala> Salas { get; set; }
    }
}
