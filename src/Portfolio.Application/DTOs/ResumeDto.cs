namespace Portfolio.Application.DTOs;

public class ResumeDto
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public string FileUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}