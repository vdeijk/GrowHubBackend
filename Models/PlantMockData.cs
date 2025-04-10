using System.Collections.Generic;

namespace BackendApp.Data
{
    public static class PlantMockData
    {
        public static List<Models.Plant> GetPlants()
        {
            return new List<Models.Plant>
            {
                new Models.Plant
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
                    TemperatureRange = "15°C - 25°C",
                    PlantType = "Perennial",
                    GrowthRate = "Moderate",
                    MatureSize = "3-8 feet tall, 2-3 feet wide",
                    BloomTime = "Spring to Fall",
                    FertilizerNeeds = "Monthly during growing season"
                },
                new Models.Plant
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
                    TemperatureRange = "18°C - 24°C",
                    PlantType = "Perennial",
                    GrowthRate = "Slow to Moderate",
                    MatureSize = "1-3 feet tall, 1-2 feet wide",
                    BloomTime = "N/A",
                    FertilizerNeeds = "Monthly during growing season"
                },
                new Models.Plant
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
                    TemperatureRange = "10°C - 20°C",
                    PlantType = "Perennial",
                    GrowthRate = "Moderate",
                    MatureSize = "10-24 inches tall",
                    BloomTime = "Spring",
                    FertilizerNeeds = "Once at planting"
                },
                new Models.Plant
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
    TemperatureRange = "10°C - 20°C",
    PlantType = "Perennial",
    GrowthRate = "Moderate",
    MatureSize = "6-20 inches tall",
    BloomTime = "Spring",
    FertilizerNeeds = "Once at planting"
},
new Models.Plant
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
    TemperatureRange = "15°C - 25°C",
    PlantType = "Perennial",
    GrowthRate = "Moderate",
    MatureSize = "1-3 feet tall, 1-2 feet wide",
    BloomTime = "Summer",
    FertilizerNeeds = "Minimal, once a year"
},
new Models.Plant
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
    TemperatureRange = "20°C - 30°C",
    PlantType = "Annual",
    GrowthRate = "Fast",
    MatureSize = "6-10 feet tall",
    BloomTime = "Summer to Fall",
    FertilizerNeeds = "Monthly during growing season"
},
new Models.Plant
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
    TemperatureRange = "18°C - 30°C",
    PlantType = "Annual",
    GrowthRate = "Fast",
    MatureSize = "1-2 feet tall",
    BloomTime = "Summer",
    FertilizerNeeds = "Monthly during growing season"
},
new Models.Plant
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
    TemperatureRange = "15°C - 25°C",
    PlantType = "Perennial",
    GrowthRate = "Fast",
    MatureSize = "1-2 feet tall",
    BloomTime = "Summer",
    FertilizerNeeds = "Monthly during growing season"
},
new Models.Plant
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
    TemperatureRange = "18°C - 30°C",
    PlantType = "Annual",
    GrowthRate = "Fast",
    MatureSize = "3-10 feet tall",
    BloomTime = "Summer",
    FertilizerNeeds = "Bi-weekly during growing season"
},
new Models.Plant
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
    TemperatureRange = "18°C - 30°C",
    PlantType = "Annual",
    GrowthRate = "Fast",
    MatureSize = "1-6 feet tall",
    BloomTime = "Summer",
    FertilizerNeeds = "Bi-weekly during growing season"
}
            };
        }
    }
}