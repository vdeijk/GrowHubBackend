namespace Models
{
    public class PlantItem
    {
        public string CommonName { get; set; } = string.Empty;
        public string Genus { get; set; } = string.Empty;
        public string ScientificName { get; set; } = string.Empty;
        public int? Id { get; set; }
        public string? SunPreference { get; set; }
        public string? WaterNeeds { get; set; }
        public string? SoilType { get; set; }
        public string? SoilPH { get; set; }
        public string? Pruning { get; set; }
        public string? StringtemperatureRange { get; set; }
        public string? PlantType { get; set; }
        public string? growthRate { get; set; }
        public string? matureSize { get; set; }
        public string? bloomTime { get; set; }
        public string? fertilizerNeeds { get; set; }
    }
}
