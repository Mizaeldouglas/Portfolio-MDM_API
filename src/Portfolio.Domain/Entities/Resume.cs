namespace Portfolio.Domain.Entities;

public class Resume
{
    public Guid Id { get; private set; }
    public string Content { get; private set; }
    public string FileUrl { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    // Construtor privado para EF Core
    private Resume()
    {
    }

    public Resume(string content, string fileUrl = null)
    {
        Id = Guid.NewGuid();
        Content = content;
        FileUrl = fileUrl;
        CreatedAt = DateTime.UtcNow;
    }

    public void Update(string content, string fileUrl = null)
    {
        Content = content;
        if (fileUrl != null)
        {
            FileUrl = fileUrl;
        }

        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateFile(string fileUrl)
    {
        FileUrl = fileUrl;
        UpdatedAt = DateTime.UtcNow;
    }
}