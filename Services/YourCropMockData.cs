using Models;
using Models.ViewModels;

namespace Data
{
    public static class YourCropMockData
    {
        private static string SetLocation()
        {
            List<LocationItem> items = LocationMockData.GetLocations().ToList();
            return items[0].Name;
        }

        private static List<YourCropItem> _yourCropItems = new List<YourCropItem>
              {
                  new YourCropItem
                  {
                      Id = 0,
                      CommonName = "Tomato",
                      Location = SetLocation(),
                      LastWatered = "2025-04-25",
                      LastFertilized = "2025-04-20",
                      LastPruned = "2025-04-18",
                      LastHarvested = "2025-04-10",
                      HealthStatus = HealthStatus.Excellent,
                      GrowthStage = GrowthStage.Maturity
                  },
                  new YourCropItem
                  {
                      Id = 1,
                      CommonName = "Strawberry",
                      Location = SetLocation(),
                      LastWatered = "2025-04-26",
                      LastFertilized = "2025-04-22",
                      LastPruned = "2025-04-21",
                      LastHarvested = "2025-04-15",
                      HealthStatus = HealthStatus.Excellent,
                      GrowthStage = GrowthStage.Maturity
                  },
                  new YourCropItem
                  {
                      Id = 2,
                      CommonName = "Blackberry",
                      Location = SetLocation(),
                      LastWatered = "2025-04-27",
                      LastFertilized = "2025-04-19",
                      LastPruned = "2025-04-25",
                      LastHarvested = "2025-04-24",
                      HealthStatus = HealthStatus.Excellent,
                      GrowthStage = GrowthStage.Maturity
                  },
                  new YourCropItem
                  {
                      Id = 3,
                      CommonName = "Carrot",
                      Location = SetLocation(),
                      LastWatered = "2025-04-25",
                      LastFertilized = "2025-04-15",
                      LastPruned = null,
                      LastHarvested = null,
                      HealthStatus = HealthStatus.Excellent,
                      GrowthStage = GrowthStage.Maturity
                  },
                  new YourCropItem
                  {
                      Id = 4,
                      CommonName = "Lettuce",
                      Location = SetLocation(),
                      LastWatered = "2025-04-27",
                      LastFertilized = "2025-04-17",
                      LastPruned = "2025-04-26",
                      LastHarvested = null,
                      HealthStatus = HealthStatus.Excellent,
                      GrowthStage = GrowthStage.Maturity
                  }
              };

        public static IEnumerable<YourCropItem> GetCrops()
        {
            return _yourCropItems;
        }

        public static YourCropItem GetCropById(int id)
        {
            return _yourCropItems.Find(_plants => _plants.Id == id);
        }

        public static void AddCrop(YourCropItem location)
        {
            location.Id = _yourCropItems.Count > 0 ? _yourCropItems[^1].Id + 1 : 1;
            _yourCropItems.Add(location);
        }

        public static void UpdateCrop(int id, YourCropItem updatedPlant)
        {
            var index = _yourCropItems.FindIndex(p => p.Id == id);
            if (index != -1)
            {
                updatedPlant.Id = id;
                _yourCropItems[index] = updatedPlant;
            }
        }

        public static void DeleteCrop(int id)
        {
            _yourCropItems.RemoveAll(location => location.Id == id);
        }
    }
}