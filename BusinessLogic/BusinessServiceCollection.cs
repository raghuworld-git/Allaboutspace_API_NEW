using BusinessLogic.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Core.Contracts.BusinessLogic;

namespace BusinessLogic
{
    public static class BusinessServiceCollection
    {
        public static void RegisterBusinessService(this IServiceCollection service)
        {
            service.AddTransient<IAstronautBL, AstronautBL>();               
        }
    }
}
