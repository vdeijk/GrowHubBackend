namespace Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string Genus { get; set; }
        public string SunPreference { get; set; }
        public string WaterNeeds { get; set; }
        public string SoilType { get; set; }
        public string SoilPH { get; set; }
        public string Pruning { get; set; }
        public string TemperatureRange { get; set; }
        public string PlantType { get; set; }
        public string GrowthRate { get; set; }
        public string MatureSize { get; set; }
        public string BloomTime { get; set; }
        public string FertilizerNeeds { get; set; }
    }
}
