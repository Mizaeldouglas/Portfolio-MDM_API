using Portfolio.Domain.Entities;

namespace Portfolio.Domain.Interfaces;

public interface IAboutMeRepository
{
    Task<AboutMe> GetAsync();
    Task<AboutMe> AddAsync(AboutMe aboutMe);
    Task UpdateAsync(AboutMe aboutMe);
}