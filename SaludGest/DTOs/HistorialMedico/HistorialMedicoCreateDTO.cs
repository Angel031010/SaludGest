using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.HistorialMedico
{
    public class HistorialMedicoCreateDTO : RegistroDTO
    {
        public int PacienteId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Diagnostico { get; set; }
        public string Notas { get; set; }
    }
}
