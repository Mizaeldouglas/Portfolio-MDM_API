using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces;

public interface ITechnologyRepository
{
    Task<Technology> GetByIdAsync(Guid id);
    Task<List<Technology>> GetAllAsync();
    Task<Technology> AddAsync(Technology technology);
    Task UpdateAsync(Technology technology);
    Task DeleteAsync(Guid id);
}