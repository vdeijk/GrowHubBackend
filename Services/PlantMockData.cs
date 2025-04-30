using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using Models;
using Models.ViewModels;

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
                SunPreference = SunPreference.FullSun,
                WaterNeeds = WaterNeeds.Medium,
                SoilType = SoilType.Loam,
                SoilPH = SoilPH.Neutral,
                Pruning = Pruning.Moderate,
                ClimateZone = ClimateZone.Temperate,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Medium,
                FertilizerNeeds = FertilizerNeeds.Medium
            },
            new PlantItem
            {
                Id = 1,
                CommonName = "Fern",
                SunPreference = SunPreference.FullShade,
                WaterNeeds = WaterNeeds.High,
                SoilType = SoilType.Peat,
                SoilPH = SoilPH.Acidic,
                Pruning = Pruning.Light,
                ClimateZone = ClimateZone.Subtropical,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Slow,
                FertilizerNeeds = FertilizerNeeds.Low
            },
            new PlantItem
            {
                Id = 2,
                CommonName = "Tulip",
                SunPreference = SunPreference.FullSun,
                WaterNeeds = WaterNeeds.Low,
                SoilType = SoilType.Sand,
                SoilPH = SoilPH.Neutral,
                Pruning = Pruning.Light,
                ClimateZone = ClimateZone.Temperate,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Fast,
                FertilizerNeeds = FertilizerNeeds.Medium
            },
            new PlantItem
            {
                Id = 3,
                CommonName = "Daffodil",
                SunPreference = SunPreference.PartialShade,
                WaterNeeds = WaterNeeds.Medium,
                SoilType = SoilType.Loam,
                SoilPH = SoilPH.Neutral,
                Pruning = Pruning.Light,
                ClimateZone = ClimateZone.Temperate,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Medium,
                FertilizerNeeds = FertilizerNeeds.Low
            },
            new PlantItem
            {
                Id = 4,
                CommonName = "Lavender",
                SunPreference = SunPreference.FullSun,
                WaterNeeds = WaterNeeds.Low,
                SoilType = SoilType.Sand,
                SoilPH = SoilPH.Alkaline,
                Pruning = Pruning.Light,
                ClimateZone = ClimateZone.Mediterranean,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Slow,
                FertilizerNeeds = FertilizerNeeds.Low
            },
            new PlantItem
            {
                Id = 5,
                CommonName = "Sunflower",
                SunPreference = SunPreference.FullSun,
                WaterNeeds = WaterNeeds.Medium,
                SoilType = SoilType.Loam,
                SoilPH = SoilPH.Neutral,
                Pruning = Pruning.Light,
                ClimateZone = ClimateZone.Temperate,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Fast,
                FertilizerNeeds = FertilizerNeeds.Medium
            },
            new PlantItem
            {
                Id = 6,
                CommonName = "Basil",
                SunPreference = SunPreference.FullSun,
                WaterNeeds = WaterNeeds.Medium,
                SoilType = SoilType.Loam,
                SoilPH = SoilPH.Neutral,
                Pruning = Pruning.Light,
                ClimateZone = ClimateZone.Subtropical,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Fast,
                FertilizerNeeds = FertilizerNeeds.High
            },
            new PlantItem
            {
                Id = 7,
                CommonName = "Mint",
                SunPreference = SunPreference.PartialShade,
                WaterNeeds = WaterNeeds.High,
                SoilType = SoilType.Loam,
                SoilPH = SoilPH.Neutral,
                Pruning = Pruning.Light,
                ClimateZone = ClimateZone.Temperate,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Medium,
                FertilizerNeeds = FertilizerNeeds.Medium
            },
            new PlantItem
            {
                Id = 8,
                CommonName = "Tomato",
                SunPreference = SunPreference.FullSun,
                WaterNeeds = WaterNeeds.High,
                SoilType = SoilType.Loam,
                SoilPH = SoilPH.Acidic,
                Pruning = Pruning.Light,
                ClimateZone = ClimateZone.Temperate,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Fast,
                FertilizerNeeds = FertilizerNeeds.High
            },
            new PlantItem
            {
                Id = 9,
                CommonName = "Cucumber",
                SunPreference = SunPreference.FullSun,
                WaterNeeds = WaterNeeds.High,
                SoilType = SoilType.Loam,
                SoilPH = SoilPH.Acidic,
                Pruning = Pruning.Light,
                ClimateZone = ClimateZone.Tropical,
                PlantType = PlantType.Tree,
                GrowthRate = GrowthRate.Fast,
                FertilizerNeeds = FertilizerNeeds.High
            },
            new PlantItem
            {
                Id = 10,
                CommonName = "Strawberry",
                SunPreference = SunPreference.FullSun,
                WaterNeeds = WaterNeeds.High,
                SoilType = SoilType.Sand,
                SoilPH = SoilPH.Acidic,
                Pruning = Pruning.Moderate,
                ClimateZone = ClimateZone.Temperate,
                PlantType = PlantType.Shrub,
                GrowthRate = GrowthRate.Fast,
                FertilizerNeeds = FertilizerNeeds.High
            },
            new PlantItem
            {
                Id = 11,
                CommonName = "Blackberry",
                SunPreference = SunPreference.FullSun,
                WaterNeeds = WaterNeeds.High,
                SoilType = SoilType.Sand,
                SoilPH = SoilPH.Acidic,
                Pruning = Pruning.Moderate,
                ClimateZone = ClimateZone.Temperate,
                PlantType = PlantType.Shrub,
                GrowthRate = GrowthRate.Fast,
                FertilizerNeeds = FertilizerNeeds.High
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
            var index = _plants.FindIndex(p => p.Id == id);
            if (index != -1)
            {
                updatedPlant.Id = id;
                _plants[index] = updatedPlant;
            }
        }


        public static void DeletePlant(int id)
        {
            _plants.RemoveAll(location => location.Id == id);
        }
    }
}