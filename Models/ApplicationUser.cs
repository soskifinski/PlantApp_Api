using Microsoft.AspNetCore.Identity;

namespace PlantApp.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;

        public ICollection<UserPlant> Plants { get; set; } = new List<UserPlant>();
    }
}
