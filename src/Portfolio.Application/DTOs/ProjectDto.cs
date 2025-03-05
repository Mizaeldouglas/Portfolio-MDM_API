namespace Portfolio.Application.DTOs;

public class ProjectDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string ProjectUrl { get; set; }
    public string RepositoryUrl { get; set; }
    public IReadOnlyList<string> Technologies { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}