using Models;

namespace Models.ViewModels
{
    public class CropItem
    {
        public string CommonName { get; set; } = string.Empty;
        public Guid Id { get; set; } = Guid.NewGuid();
        public int WaterCycle { get; set; }
        public int PruningCycle { get; set; }
        public int FertilizationCycle { get; set; }
        public int HarvestCycle { get; set; }
        public string? Notes { get; set; }
        public Month HarvestStart { get; set; }
        public Month HarvestEnd { get; set; }
        public Month PruningStart { get; set; }
        public Month PruningEnd { get; set; }
        public Month FertilizingStart { get; set; }
        public Month FertilizingEnd { get; set; }
        public float PHMin { get; set; }
        public float PHMax { get; set; }
        public int TemperatureMin { get; set; }
        public int TemperatureMax { get; set; }
    }
}
