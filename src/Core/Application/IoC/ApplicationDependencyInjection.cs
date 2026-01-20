using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Application.IoC
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        } 
    }
}