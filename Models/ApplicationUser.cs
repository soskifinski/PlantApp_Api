using Microsoft.AspNetCore.Identity;

namespace PlantApp.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<UserPlant> UserPlants { get; set; } = new List<UserPlant>();
    }
}
