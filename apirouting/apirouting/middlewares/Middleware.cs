using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace apirouting.middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware
    {
        private readonly RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }
        
        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Headers["Authorization"].Equals("False"))
            {
                httpContext.Response.StatusCode = 401;
            }
            else if (httpContext.Request.Path.Equals("/Home"))
            {
                await httpContext.Response.WriteAsync("Hello ");
            }
            else
            {
                await httpContext.Response.WriteAsync("Dear Readers!");
            }
            return;
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
