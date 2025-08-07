namespace SaludGest.Models
{
    public class Medico : Registro
    {
        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int EspecialidadId { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int DepartamentoId { get; set; }

        public IEnumerable<Cita> Citas { get; set; }

        public Especialidad Especialidad { get; set; }
        public Departamento Departamento { get; set; }
    }
}
