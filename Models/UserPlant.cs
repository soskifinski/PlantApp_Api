namespace PlantApp.Api.Models
{
    public class UserPlant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Edible { get; set; }

        public int UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
