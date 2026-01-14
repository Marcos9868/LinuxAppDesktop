using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        Task AddAsync(Project project);   
        Task<IReadOnlyList<Project>> GetAllList();     
    }
}