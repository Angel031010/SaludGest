namespace SaludGest.Constans
{
    public class Messages
    {
        public static class Success
        {
            //Creación
            public const string PacienteCreado = "El paciente se ha registrado exitosamente.";
            public const string EspecialidadCreada = "La especialidad se ha registrado exitosamente.";


            //Actualización
            public const string PacienteActualizado = "El paciente se ha actualizado exitosamente.";
            public const string EspecialidadActualizada = "La especialidad se ha actualizado exitosamente.";


            //Eliminación
            public const string PacienteEliminado = "El paciente se ha eliminado exitosamente.";
            public const string EspecialidadEliminada = "La especialidad se ha eliminado exitosamente.";
        }

        public static class Error
        {
            // Existencia
            public const string PacienteNoEncontradoID = "No se encontró ningún paciente con ID: {0}.";
            public const string PacienteNoExiste = "El paciente no existe.";

            public const string EspecialidadNoEncontradaID = "No se encontró ninguna especialidad con ID: {0}.";
            public const string EspecialidadNoExiste = "La especialidad no existe.";


            //Creación
            public const string ErrorCrearPaciente = "Ha ocurrido un error al registrar el paciente.";

            public const string ErrorCrearEspecialidad = "Ha ocurrido un error al registrar la especialidad.";


            //Actualización
            public const string ErrorActualizarPaciente= "Error al actualizar información del paciente.";

            public const string ErrorActualizarEspecialidad = "Error al actualizar información de la especialidad.";


            //Eliminación
            public const string ErrorEliminarPaciente = "Error al eliminar el paciente.";

            public const string ErrorEliminarEspecialidad = "Error al eliminar la especialidad.";
        }

        public static class Validation
        {
            public const string UnSupportedFileType = "El tipo de archivo no es soportado.";
        }
    }
}
