using Microsoft.Data.SqlClient;
using SaludGest.Services.Interfaces;
using System.Net;

namespace SaludGest.Services.Implementations
{
    public class CustomException : ICustomExcepction
    {
        private readonly ILogger<CustomException> _logger;
        public CustomException(ILogger<CustomException> logger)
        {
            _logger = logger;
        }

        public string GetExeption(Exception exception)
        {
            // Log la excepción original para debugging
            _logger?.LogError(exception, "Error capturado: {ExeptionType} - {Message}", exception.GetType().Name, exception.Message);

            string message = "Error inesperado";


            // IMPORTANTE: Las excepciones mas especificas deben ir PRIMERO
            if (exception is NullReferenceException)
                message = "Objeto no encontrado";
            else if (exception is InvalidCastException)
                message = "Ocurrio un error con algun tipo de datos";
            else if (exception is ArgumentException)
                message = "Los datos proporcionados no son válidos";
            else if (exception is TimeoutException)
                message = "La operación tardó demasiado tiempo en completarse";
            else if (exception is SqlException)
                message = "Error en la base de datos";
            else if (exception is WebException)
                message = "El servidor remoto devolvio un error";
            else if (exception is ApplicationException)
                message = exception.Message; // Mensaje personalizado de la excepción de aplicación
            else if (exception is SystemException)
                message = "Ocurrio un error al obtener las secciones";

            return message;
        }
    }
}
