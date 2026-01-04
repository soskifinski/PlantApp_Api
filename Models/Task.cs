namespace PlantApp.Api.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public DateTime NextDueOn { get; set; }
        public bool Status { get; set; }

        public int UserPlantId { get; set; }
        public UserPlant UserPlant { get; set; } = null!;
    }
}
