using Models;
namespace Data;
using Models.ViewModels;

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
    Amount = 4,
    CommonName = "Blackberry",
    Location = SetLocation(),
    Planted = new DateTime(2024, 10, 20),
    LastWatered = new DateTime(2025, 4, 25),
    LastFertilized = new DateTime(2025, 4, 20),
    LastPruned = new DateTime(2025, 4, 18),
    LastHarvested = new DateTime(2025, 4, 10),
},
new YourCropItem
{
    Id = 1,
    Amount = 3,
    CommonName = "Raspberry",
    Location = SetLocation(),
    Planted = new DateTime(2024, 10, 20),
    LastWatered = new DateTime(2025, 4, 26),
    LastFertilized = new DateTime(2025, 4, 22),
    LastPruned = new DateTime(2025, 4, 21),
    LastHarvested = new DateTime(2025, 4, 15),
},
new YourCropItem
{
    Id = 2,    
    Amount = 2,
    CommonName = "Apricot",
    Location = SetLocation(),
    Planted = new DateTime(2024, 10, 20),
    LastWatered = new DateTime(2025, 4, 27),
    LastFertilized = new DateTime(2025, 4, 19),
    LastPruned = new DateTime(2025, 4, 25),
    LastHarvested = new DateTime(2025, 4, 24),
},
new YourCropItem
{
    Id = 3,
    Amount = 3,
    CommonName = "Sea Buckthorns",
    Location = SetLocation(),
    Planted = new DateTime(2024, 10, 20),
    LastWatered = new DateTime(2025, 4, 27),
    LastFertilized = new DateTime(2025, 4, 19),
    LastPruned = new DateTime(2025, 4, 25),
    LastHarvested = new DateTime(2025, 4, 24),
},
new YourCropItem
{
    Id = 4,
    Amount = 2,
    CommonName = "Blueberries",
    Location = SetLocation(),
    Planted = new DateTime(2024, 10, 20),
    LastWatered = new DateTime(2025, 4, 27),
    LastFertilized = new DateTime(2025, 4, 19),
    LastPruned = new DateTime(2025, 4, 25),
    LastHarvested = new DateTime(2025, 4, 24),
},
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