using Allaboutspace_API.Configuration;

namespace Allaboutspace_API
{
    public class Program
    {
        private static string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            RegisterServices.Register(builder);

            var app = builder.Build();

            // Add middlewares
            RegisterMiddlewares(app);

            app.Run();
        }

        private static void RegisterMiddlewares(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{            
            app.UseSwagger();
            app.UseSwaggerUI();
            //}
            // app.ConfigureExceptionHandler();

            app.UseCors(MyAllowSpecificOrigins);
            app.UseHttpsRedirection();
            app.UseAuthorization();


            //app.UseMiddleware<APIKeyMiddleware>();

            app.UseResponseCaching();
            app.MapControllers();
            app.UseRouting();
        }
    }

}