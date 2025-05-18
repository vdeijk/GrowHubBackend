namespace Models
{
    public class ReadingItem
    {
        public string Title { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid BatchId { get; set; }
        public SoilDryness SoilDryness { get; set; }
        public float SoilPH { get; set; }
        public HealthStatus HealthStatus { get; set; }
        public GrowthStage GrowthStage { get; set; }
        public float Temperature { get; set; }
        public string? Notes { get; set; }
        public string Date { get; set; }
    }
}
