using Models.ViewModels;

namespace Models
{
    public class YourCropItem
    {
        public int? Id { get; set; }
        public string CommonName { get; set; } = string.Empty;
        public string Location { get; set; }
        public string? LastWatered { get; set; }
        public string? LastFertilized { get; set; }
        public string? LastPruned { get; set; }
        public string? LastHarvested { get; set; }
        public HealthStatus HealthStatus { get; set; }
        public GrowthStage GrowthStage { get; set; }
    }
}

