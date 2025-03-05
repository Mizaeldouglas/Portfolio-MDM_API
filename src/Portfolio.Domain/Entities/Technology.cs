namespace Portfolio.Domain.Entities;

public class Technology
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string IconUrl { get; private set; }
    public int ProficiencyLevel { get; private set; } // 1-5
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    // Construtor privado para EF Core
    private Technology()
    {
    }

    public Technology(string name, string description, string iconUrl, int proficiencyLevel)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        IconUrl = iconUrl;
        ProficiencyLevel = Math.Clamp(proficiencyLevel, 1, 5);
        CreatedAt = DateTime.UtcNow;
    }

    public void Update(string name, string description, string iconUrl, int proficiencyLevel)
    {
        Name = name;
        Description = description;
        IconUrl = iconUrl;
        ProficiencyLevel = Math.Clamp(proficiencyLevel, 1, 5);
        UpdatedAt = DateTime.UtcNow;
    }
}