using Application.Abstractions;
using Application.DTOs;
using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Projects.GetProjects
{
  public sealed class GetProjectsHandler : IRequestHandler<GetProjectsQuery, IReadOnlyList<ProjectDTO>>
  {
    private readonly IProjectRepository _repository;
    public GetProjectsHandler(IProjectRepository repository)
    {
      _repository = repository;
    }

    public Task<IReadOnlyList<ProjectDTO>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
    {
      IReadOnlyList<ProjectDTO> result = [
        new(Guid.NewGuid(), "Codetech Project")
      ];
      return Task.FromResult(result);
    }

    /*public Task<IReadOnlyList<ProjectDTO>> HandleAsync(GetProjectsQuery input)
    {
      IReadOnlyList<ProjectDTO> result = [
        new(Guid.NewGuid(), "Codetech Project")
      ];
      return Task.FromResult(result);
    }*/
  }
}