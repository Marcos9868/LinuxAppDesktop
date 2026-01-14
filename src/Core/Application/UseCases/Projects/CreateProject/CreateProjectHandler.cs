using Application.Abstractions;
using Application.Interfaces.Repositories;
using Domain.Entities;
using Domain.ValueObjects;

namespace Application.UseCases.Projects.CreateProject
{
  public sealed class CreateProjectHandler : IUseCase<CreateProjectCommand, CreateProjectResult>
  {
    private readonly IProjectRepository _repository;
    public CreateProjectHandler(IProjectRepository repository) => _repository = repository; 
    public async Task<CreateProjectResult> HandleAsync(CreateProjectCommand input)
    {
        var project = Project.Create(
            new ProjectName(input.Name),
            new ProjectDescription(input.Description)
        );           
        await _repository.AddAsync(project);
        
        return new CreateProjectResult(project.Id);
    }
  }
}