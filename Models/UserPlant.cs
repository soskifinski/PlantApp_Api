using System.ComponentModel.DataAnnotations;

namespace PlantApp.Api.Models
{
    public class UserPlant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Edible { get; set; }

        [Required] 
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; } = null!;
        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
