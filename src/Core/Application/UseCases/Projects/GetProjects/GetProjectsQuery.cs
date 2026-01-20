using Application.DTOs;
using MediatR;

namespace Application.UseCases.Projects.GetProjects
{
    public sealed record GetProjectsQuery : IRequest<IReadOnlyList<ProjectDTO>>;
}