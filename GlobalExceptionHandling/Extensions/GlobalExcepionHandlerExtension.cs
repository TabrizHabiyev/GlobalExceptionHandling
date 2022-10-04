
using GlobalExceptionHandling.Middlewares;

namespace GlobalExceptionHandling.Extensions;

public static class GlobalExcepionHandlerExtension
{
    public static void UseGlobalExcepionHandler(this IApplicationBuilder app)
    {
        app.UseMiddleware<GlobalExcepionHandler>();
    }
}
