namespace SaludGest.Models
{
    public class Registro
    {
        public bool Activo { get; set; } = true;
        public bool Eliminado { get; set; } = false;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

    }
}
