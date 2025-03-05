namespace Portfolio.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IUserRepository UserRepository { get; }
    IAboutMeRepository AboutMeRepository { get; }
    ITechnologyRepository TechnologyRepository { get; }
    IProjectRepository ProjectRepository { get; }
    IResumeRepository ResumeRepository { get; }
        
    Task<int> SaveChangesAsync();
}