
namespace WeatherApp.RestApi.OAuth2.Dtos;

public class UserLoginDto
{
    [Required]
    public string Username { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;
}
