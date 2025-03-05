using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces;

public interface IResumeRepository
{
    Task<Resume> GetAsync();
    Task<Resume> AddAsync(Resume resume);
    Task UpdateAsync(Resume resume);
}