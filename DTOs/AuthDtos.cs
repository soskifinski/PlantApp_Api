namespace PlantApp.Api.DTOs
{
    public class AuthDtos
    {
        public record RegisterDto(string Email, string Password);
        public record LoginDto(string Email, string Password);
    }
}
