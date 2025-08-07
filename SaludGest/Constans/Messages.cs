namespace SaludGest.Constans
{
    public class Messages
    {
        public static class Success
        {
            //Creación
            public const string PacienteCreado = "El paciente se ha registrado exitosamente.";


            //Actualización
            public const string PacienteActualizado = "El paciente se ha actualizado exitosamente.";


            //Eliminación
            public const string PacienteEliminado = "El paciente se ha eliminado exitosamente.";
        }

        public static class Error
        {
            // Existencia
            public const string PacienteNoEncontradoID = "No se encontró ningún paciente con ID: {0}.";
            public const string PacienteNoExiste = "El paciente no existe.";


            //Creación
            public const string ErrorCrearPaciente = "Ha ocurrido un error al registrar el paciente.";


            //Actualización
            public const string ErrorActualizarPaciente= "Error al actualizar información del paciente.";


            //Eliminación
            public const string ErrorEliminarPaciente = "Error al eliminar el paciente.";
        }

        public static class Validation
        {
            public const string UnSupportedFileType = "El tipo de archivo no es soportado.";
        }
    }
}
