using Microsoft.AspNetCore.Mvc;
using Repository;
using BusinessLogic;
using HttpWrapper;
using Allaboutspace_API.Filters;

namespace Allaboutspace_API.Configuration
{
    public  static class RegisterServices
    {
        private static string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public static void Register(WebApplicationBuilder builder)
        {
            #region Adding CORS support
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:4200",
                                             "https://allaboutspace.netlify.app");
                    }
                    );
            });
            #endregion

            builder.Services.AddResponseCaching();

            builder.Services.AddMapster();

            builder.Services.AddControllers(
                options =>
                {
                    options.Filters.Add<HttpResponseExceptionFilter>();
                    options.CacheProfiles.Add("DefaultOneDayById",
                        new CacheProfile()
                        {
                            Duration = 86400,
                            VaryByQueryKeys = new string[] { "id" },
                            NoStore = false,
                            Location = ResponseCacheLocation.Any
                        });

                    options.CacheProfiles.Add("DefaultOneDay",
                       new CacheProfile()
                       {
                           Duration = 86400,
                           VaryByQueryKeys = new string[] { "*" },
                           NoStore = false,
                           Location = ResponseCacheLocation.Any
                       });

                    options.CacheProfiles.Add("DefaultOneWeek",
                       new CacheProfile()
                       {
                           Duration = 604800,
                           VaryByQueryKeys = new string[] { "*" },
                           NoStore = false,
                           Location = ResponseCacheLocation.Any
                       });
                }
                );

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            #region Custom Dependency Injection

            builder.Services.RegisterRepositoryService();
            builder.Services.RegisterBusinessService();
            builder.Services.RegisterHttpWrapperService();

            #endregion

        }
    }
}
