namespace Portfolio.Domain.Entities;

public class Project
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string ImageUrl { get; private set; }
    public string ProjectUrl { get; private set; }
    public string RepositoryUrl { get; private set; }
    private List<string> _technologies = new List<string>();
    public IReadOnlyList<string> Technologies => _technologies.AsReadOnly();
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    // Construtor privado para EF Core
    private Project()
    {
    }

    public Project(string title, string description, string imageUrl, string projectUrl, string repositoryUrl,
        List<string> technologies = null)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        ImageUrl = imageUrl;
        ProjectUrl = projectUrl;
        RepositoryUrl = repositoryUrl;
        if (technologies != null)
        {
            _technologies = technologies;
        }

        CreatedAt = DateTime.UtcNow;
    }

    public void Update(string title, string description, string imageUrl, string projectUrl, string repositoryUrl,
        List<string> technologies = null)
    {
        Title = title;
        Description = description;
        ImageUrl = imageUrl;
        ProjectUrl = projectUrl;
        RepositoryUrl = repositoryUrl;
        if (technologies != null)
        {
            _technologies = technologies;
        }

        UpdatedAt = DateTime.UtcNow;
    }

    public void AddTechnology(string technology)
    {
        if (!_technologies.Contains(technology))
        {
            _technologies.Add(technology);
            UpdatedAt = DateTime.UtcNow;
        }
    }

    public void RemoveTechnology(string technology)
    {
        if (_technologies.Contains(technology))
        {
            _technologies.Remove(technology);
            UpdatedAt = DateTime.UtcNow;
        }
    }
}