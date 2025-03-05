namespace Portfolio.Application.DTOs;

public class AuthResponseDto
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public UserDto User { get; set; }
}