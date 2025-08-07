namespace SaludGest.Models
{
    public class Especialidad : Registro
    {
        public int EspecialidadId { get; set; }
        public string NombreEspecialidad { get; set; }
        public string Descripcion { get; set; }
        public IEnumerable<Medico> Medicos { get; set; }
    }
}
