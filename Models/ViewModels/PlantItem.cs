using Models;

namespace Models.ViewModels
{
    public class PlantItem
    {
        public string CommonName { get; set; } = string.Empty;
        public int? Id { get; set; }
        public SunPreference? SunPreference { get; set; }
        public WaterNeeds? WaterNeeds { get; set; }
        public SoilType? SoilType { get; set; }
        public SoilPH? SoilPH { get; set; }
        public Pruning? Pruning { get; set; }
        public ClimateZone? ClimateZone { get; set; }
        public PlantType? PlantType { get; set; }
        public GrowthRate? GrowthRate { get; set; }
        public FertilizerNeeds? FertilizerNeeds { get; set; }
    }
}
