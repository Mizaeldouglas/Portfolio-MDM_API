using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces;

public interface IProjectRepository
{
    Task<Project> GetByIdAsync(Guid id);
    Task<List<Project>> GetAllAsync();
    Task<Project> AddAsync(Project project);
    Task UpdateAsync(Project project);
    Task DeleteAsync(Guid id);
}