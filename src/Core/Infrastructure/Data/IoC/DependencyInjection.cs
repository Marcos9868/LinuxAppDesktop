using Application.Interfaces.Repositories;
using Infrastructure.Data.InMemory;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data.IoC
{
    public static class DependencyInjection
    {
       public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IProjectRepository, InMemoryProjectRepository>();
            return services;
        } 
    }
}