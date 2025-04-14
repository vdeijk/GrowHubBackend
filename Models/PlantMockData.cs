using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using Models;

namespace Data
{
    public static class PlantMockData
    {
        private static List<PlantItem> _plants = new List<PlantItem>
        {
                new PlantItem
                {
                    Id = 0,
                    CommonName = "Rose",
                    ScientificName = "Rosa",
                    Genus = "Rosa",
                    SunPreference = "Full Sun",
                    WaterNeeds = "Moderate",
                    SoilType = "Loamy",
                    SoilPH = "6.0 - 7.0",
                    Pruning = "Spring",
                },
                new PlantItem
                {
                    Id = 1,
                    CommonName = "Fern",
                    ScientificName = "Pteridophyta",
                    Genus = "Pteridium",
                    SunPreference = "Shade",
                    WaterNeeds = "High",
                    SoilType = "Rich, well-drained",
                    SoilPH = "5.0 - 6.5",
                    Pruning = "Remove dead fronds",
                    PlantType = "Perennial",
                },
                new PlantItem
                {
                    Id = 2,
                    CommonName = "Tulip",
                    ScientificName = "Tulipa",
                    Genus = "Tulipa",
                    SunPreference = "Full Sun",
                    WaterNeeds = "Low",
                    SoilType = "Well-drained",
                    SoilPH = "6.0 - 7.0",
                    Pruning = "Remove spent flowers",
                    PlantType = "Perennial",
                },
                new PlantItem
{
    Id = 3,
    CommonName = "Daffodil",
    ScientificName = "Narcissus",
    Genus = "Narcissus",
    SunPreference = "Full Sun to Partial Shade",
    WaterNeeds = "Moderate",
    SoilType = "Well-drained",
    SoilPH = "6.0 - 7.0",
    Pruning = "Remove spent flowers",
    PlantType = "Perennial",
},
new PlantItem
{
    Id = 4,
    CommonName = "Lavender",
    ScientificName = "Lavandula",
    Genus = "Lavandula",
    SunPreference = "Full Sun",
    WaterNeeds = "Low",
    SoilType = "Well-drained, sandy",
    SoilPH = "6.5 - 7.5",
    Pruning = "Prune after flowering",
    PlantType = "Perennial",
},
new PlantItem
{
    Id = 5,
    CommonName = "Sunflower",
    ScientificName = "Helianthus annuus",
    Genus = "Helianthus",
    SunPreference = "Full Sun",
    WaterNeeds = "Moderate",
    SoilType = "Well-drained",
    SoilPH = "6.0 - 7.5",
    Pruning = "Remove spent flowers",
    PlantType = "Annual",
},
new PlantItem
{
    Id = 6,
    CommonName = "Basil",
    ScientificName = "Ocimum basilicum",
    Genus = "Ocimum",
    SunPreference = "Full Sun",
    WaterNeeds = "Moderate",
    SoilType = "Well-drained",
    SoilPH = "6.0 - 7.5",
    Pruning = "Pinch back regularly",
    PlantType = "Annual",
},
new PlantItem
{
    Id = 7,
    CommonName = "Mint",
    ScientificName = "Mentha",
    Genus = "Mentha",
    SunPreference = "Partial Shade",
    WaterNeeds = "High",
    SoilType = "Moist, well-drained",
    SoilPH = "6.0 - 7.0",
    Pruning = "Pinch back regularly",
    PlantType = "Perennial",
},
new PlantItem
{
    Id = 8,
    CommonName = "Tomato",
    ScientificName = "Solanum lycopersicum",
    Genus = "Solanum",
    SunPreference = "Full Sun",
    WaterNeeds = "High",
    SoilType = "Rich, well-drained",
    SoilPH = "6.0 - 6.8",
    Pruning = "Prune suckers",
    PlantType = "Annual",
},
new PlantItem
{
    Id = 9,
    CommonName = "Cucumber",
    ScientificName = "Cucumis sativus",
    Genus = "Cucumis",
    SunPreference = "Full Sun",
    WaterNeeds = "High",
    SoilType = "Rich, well-drained",
    SoilPH = "6.0 - 6.8",
    Pruning = "Prune vines",
    PlantType = "Annual",
}
            };


        public static IEnumerable<PlantItem> GetPlants()
        {
            return _plants;
        }

        public static PlantItem GetPlantById(int id)
        {
            return _plants.Find(_plants => _plants.Id == id);
        }

        public static void AddPlant(PlantItem location)
        {
            location.Id = _plants.Count > 0 ? _plants[^1].Id + 1 : 1;
            _plants.Add(location);
        }

        public static void UpdatePlant(int id, PlantItem updatedPlant)
        {
            var plant = _plants.Find(l => l.Id == id);
            if (plant != null)
            {
                plant.Id = updatedPlant.Id;
                plant.CommonName = updatedPlant.CommonName;
                plant.ScientificName = updatedPlant.ScientificName;
                plant.Genus = updatedPlant.Genus;
            }
        }

        public static void DeletePlant(int id)
        {
            _plants.RemoveAll(location => location.Id == id);
        }
    }
}