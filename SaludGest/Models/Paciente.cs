namespace SaludGest.Models
{
    public class Paciente : Registro
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string? FotoUrl { get; set; }

        public IEnumerable<Cita> Citas { get; set; }
        public IEnumerable<HistorialMedico> HistorialesMedicos { get; set; }
        public IEnumerable<Factura> Facturas { get; set; }
    }
}
