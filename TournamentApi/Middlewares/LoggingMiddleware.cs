using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Text;

namespace TournamentApi.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

           
            var endpoint = context.Request.Path;
            var requestMethod = context.Request.Method;
            if (!requestMethod.Equals(HttpMethod.Get))
            {
                var requestTime = DateTime.UtcNow;
                var logMessage = $"Acceso al endpoint '{endpoint}'. Método: {requestMethod}, Fecha y Hora: '{requestTime}'"; 
                Console.WriteLine(logMessage);
            }

            await _next(context);
            
        }

    }
}

