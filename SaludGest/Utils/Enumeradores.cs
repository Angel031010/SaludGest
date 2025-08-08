namespace SaludGest.Utils
{
    public class Enumeradores
    {
        public enum TipoSala
        {
            Consulta,
            Emergencia,
            Quirófano,
            Examen,
            Recuperación
        }
        public enum EstadoCita
        {
            Programada,
            Completada,
            Cancelada,
            NoAsistida
        }
        public enum EstadoFactura
        {
            Pagada,
            Pendiente,
            Cancelada
        }

        public enum Genero
        {
            Masculino,
            Femenino,
            Otro
        }
    }
}
