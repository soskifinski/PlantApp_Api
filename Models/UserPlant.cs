using System.ComponentModel.DataAnnotations;

namespace PlantApp.Api.Models
{
    public class UserPlant
    {
        public int Id { get; set; }

        [Required] 
        public string UserId { get; set; }

        [Required]
        public int PlantId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;
        public virtual Plant Plant { get; set; } = null!;
        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
