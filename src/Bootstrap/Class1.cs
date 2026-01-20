using Application.UseCases.Projects.CreateProject;
using Application.UseCases.Projects.GetProjects;
using Infrastructure.Data.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Bootstrap.Data.IoC;

public static class Class1 
{
  public static IServiceProvider Build()
  {
    var services = new ServiceCollection();
    services.AddTransient<CreateProjectHandler>();
    services.AddTransient<GetProjectsHandler>();

    services.AddInfrastructure();
    return services.BuildServiceProvider();
  }
}
