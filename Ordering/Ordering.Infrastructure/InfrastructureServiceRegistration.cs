using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Ordering.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
        {
            return services;
        }
    }
}
