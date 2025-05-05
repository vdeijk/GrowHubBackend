using Models;

namespace Data
{
    public static class MeasurementsMockData
    {
        private static List<MeasurementItem> _measurementItems = new List<MeasurementItem>
            {
                new MeasurementItem
                {
                    Id=0,
                    Title = "Tomato Plant 1",
                    SoilDryness = SoilDryness.Moist,
                    SoilPH = 6.5f,
                    HealthStatus = HealthStatus.Good,
                    GrowthStage = GrowthStage.Flowering,
                    Date = DateTime.Now.ToString("yyyy-MM-dd")
                },
                new MeasurementItem
                { 
                    Id=1,
                    Title = "Cucumber Plant 2",
                    SoilDryness = SoilDryness.Wet,
                    SoilPH = 6.8f,
                    HealthStatus = HealthStatus.Good,
                    GrowthStage = GrowthStage.Vegetative,
                    Date = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")
                },
                new MeasurementItem
                {
                     Id=2,
                    Title = "Pepper Plant 3",
                    SoilDryness = SoilDryness.Dry,
                    SoilPH = 5.9f,
                    HealthStatus = HealthStatus.Good,
                    GrowthStage = GrowthStage.Seedling,
                    Date = DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd")
                }
        };

        public static IEnumerable<MeasurementItem> GetMeasurements()
        {
            return _measurementItems;
        }

        public static MeasurementItem GetMeasurementById(int id)
        {
            return _measurementItems.Find(_plants => _plants.Id == id);
        }

        public static void AddMeasurement(MeasurementItem location)
        {
            location.Id = _measurementItems.Count > 0 ? _measurementItems[^1].Id + 1 : 1;
            _measurementItems.Add(location);
        }

        public static void UpdateMeasurement(int id, MeasurementItem updatedPlant)
        {
            var index = _measurementItems.FindIndex(p => p.Id == id);
            if (index != -1)
            {
                updatedPlant.Id = id;
                _measurementItems[index] = updatedPlant;
            }
        }

        public static void DeleteMeasurement(int id)
        {
            _measurementItems.RemoveAll(location => location.Id == id);
        }
    }
}