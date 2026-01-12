using Domain.Abstractions;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public sealed class Project : Entity<ProjectId>
    {
        public ProjectName Name { get; private set; }
        public ProjectDescription Description { get; private set; }
        public ProjectStatus Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        private Project(ProjectId id, ProjectName name, ProjectDescription description) : base(id)
        {
            Name = name;
            Description = description;
            Status = ProjectStatus.Draft;
            CreatedAt = DateTime.UtcNow;
        }
        public static Project Create(ProjectName name, ProjectDescription description)
        {
            return new Project(
                ProjectId.New(),
                name,
                description
            );
        }
        public void Activate()
        {
            if (Status != ProjectStatus.Draft)
                throw new InvalidOperationException("Somente projetos em rascunho podem ser ativados.");

            Status = ProjectStatus.Active;
        }
        public void Complete()
        {
            if (Status != ProjectStatus.Active)
                throw new InvalidOperationException("Somente projetos ativos podem ser concluídos.");

            Status = ProjectStatus.Completed;
        }
        public void Archive()
        {
            if (Status == ProjectStatus.Archived)
                return;

            Status = ProjectStatus.Archived;
        }
    }
}