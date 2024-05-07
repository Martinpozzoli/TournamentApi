using Microsoft.AspNetCore.Http.HttpResults;

namespace TournamentApi.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException("Revisar petición: " + context.Request.Method);
            }
        }
    }
}
