using Microsoft.AspNetCore.Builder;
using WebApi.Middlewares;

namespace WebApi.Extensions
{
    public static class CustomExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomExceptionMiddle(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}
