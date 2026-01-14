using Application.Abstractions;
using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Application.UseCases.Projects.GetProjects
{
  public sealed class GetProjectsHandler : IUseCase<GetProjectsQuery, IReadOnlyList<Project>>
  {
    private readonly IProjectRepository _repository;
    public GetProjectsHandler(IProjectRepository repository)
    {
       _repository = repository; 
    }
    public async Task<IReadOnlyList<Project>> HandleAsync(GetProjectsQuery input)
    {
        return await _repository.GetAllList();
    }
  }
}