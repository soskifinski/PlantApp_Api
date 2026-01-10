namespace PlantApp.Api.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Latin { get; set; }
        public string ImageName { get; set; }
        public string Category { get; set; }
        public bool Poisonous { get; set; }
        public bool Edible { get; set; }
        public bool HardyInWinter { get; set; }
        public string LightRequirement { get; set; }
        public string LeafColor { get; set; }
        public string BloomingPeriod { get; set; }

        public short[] HarvestMonths { get; set; }
        public short[] FertilizingCycle { get; set; }
        public short[] WateringCycle { get; set; }

        public string SoilType { get; set; }


        public virtual List<UserPlant> UserPlants { get; set; }
    }
}
