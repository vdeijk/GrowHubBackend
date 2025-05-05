using Models.ViewModels;

namespace Models
{
    public class YourCropItem
    {
        public int? Id { get; set; }
        public int? CropId { get; set; }
        public string CommonName { get; set; } = string.Empty;
        public int Amount { get; set; }
        public int DatabaseId { get; set; }
        public string Location { get; set; }
        public DateTime Planted { get; set; }
        public DateTime? LastWatered { get; set; }
        public DateTime? LastFertilized { get; set; }
        public DateTime? LastPruned { get; set; }
        public DateTime? LastHarvested { get; set; }
        public string? Notes { get; set; }
    }
}

