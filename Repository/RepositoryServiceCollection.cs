using Core.Contracts.Repository;
using Microsoft.Extensions.DependencyInjection;
using Repository.Implementations;

namespace Repository
{
    public static class RepositoryServiceCollection
    {
        public static void RegisterRepositoryService(this IServiceCollection services)
        {
            services.AddTransient<IAstronautRepository,AstronautRepository>();
            services.AddTransient<IConfigurationRepository, ConfigurationRepository>();
        }
    }
}
