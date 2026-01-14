using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Infrastructure.Data.InMemory
{
  public sealed class InMemoryProjectRepository : IProjectRepository
  {
    private readonly List<Project> _projects = new();
    public Task AddAsync(Project project)
    {
      _projects.Add(project);
      return Task.CompletedTask;
    }
    public Task<IReadOnlyList<Project>> GetAllList()
    {
      return Task.FromResult<IReadOnlyList<Project>>(_projects.AsReadOnly());
    }
  }
}