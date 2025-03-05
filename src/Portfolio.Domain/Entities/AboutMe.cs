namespace Portfolio.Domain.Entities;

public class AboutMe
{
    public Guid Id { get; private set; }
    public string Content { get; private set; }
    public string Title { get; private set; }
    public string ImageUrl { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    // Construtor privado para EF Core
    private AboutMe()
    {
    }

    public AboutMe(string title, string content, string imageUrl = null)
    {
        Id = Guid.NewGuid();
        Title = title;
        Content = content;
        ImageUrl = imageUrl;
        CreatedAt = DateTime.UtcNow;
    }

    public void Update(string title, string content, string imageUrl = null)
    {
        Title = title;
        Content = content;
        if (imageUrl != null)
        {
            ImageUrl = imageUrl;
        }

        UpdatedAt = DateTime.UtcNow;
    }
}