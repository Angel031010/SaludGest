using SaludGest.DTOs.Registro;

namespace SaludGest.DTOs.HistorialMedico
{
    public class HistorialMedicoReadDTO : RegistroDTO
    {
        public int HistorialMedicoId { get; set; }
        public string Diagnostico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string NombrePaciente { get; set; }
    }
}
