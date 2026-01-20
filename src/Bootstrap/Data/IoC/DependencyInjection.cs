using Infrastructure.Data.IoC;
using Application.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Bootstrap.Data.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBootstrap(this IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure();

            return services;
        }
    }
}