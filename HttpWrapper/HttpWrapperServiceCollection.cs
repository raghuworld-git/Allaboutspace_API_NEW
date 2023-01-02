

using Microsoft.Extensions.DependencyInjection;
using Core.Contracts.Repository;

namespace HttpWrapper
{
    public static class HttpWrapperServiceCollection
    {
        public static void RegisterHttpWrapperService(this IServiceCollection service)
        {
            service.AddScoped<IHttpWrapper, FlurlHttpWrapper>();
        }
    }
}
