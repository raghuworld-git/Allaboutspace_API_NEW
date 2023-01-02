using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace Allaboutspace_API.Configuration
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this WebApplication app)
        {
            //app.UseExceptionHandler(appError =>
            //{
            //    appError.Run(async context =>
            //    {
            //        // context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            //        context.Response.ContentType = "application/json";
            //        var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
            //        if (contextFeature != null)
            //        {
            //            await context.Response.WriteAsync(new DTO.ErrorDetails()
            //            {
            //                StatusCode = context.Response.StatusCode,
            //                Message = "Internal Server Error."
            //            }.ToString());
            //        }
            //    });
            //});

            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                    var exception = exceptionHandlerPathFeature.Error;

                    dynamic httpError = exception.InnerException;
                    if (httpError.statusCode)
                    await context.Response.WriteAsJsonAsync(new { error = exception.Message });
                });
            });
        }
    }
}
