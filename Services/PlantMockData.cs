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
                    Id=0,
                    CommonName = "Blackberry",
                    WaterCycle = 3,
                    PruningCycle = 365,
                    FertilizationCycle = 182,
                    HarvestCycle = 7,
                    Notes = "",
                    HarvestStart = Month.September,
                    HarvestEnd  = Month.October,
                    PruningStart =  Month.October,
                    PruningEnd  = Month.February,
                    FertilizingStart = Month.March,
                    FertilizingEnd = Month.October,
                    PHMin = 6.0f,
                    PHMax = 7f,
                    TemperatureMin = -30,
                    TemperatureMax = 30
                },
                 new PlantItem
                {
                    Id=0,
                    CommonName = "Raspberry",
                    WaterCycle = 3,
                    PruningCycle = 365,
                    FertilizationCycle = 182,
                    HarvestCycle = 7,
                    Notes = "",
                    HarvestStart = Month.September,
                    HarvestEnd  = Month.October,
                    PruningStart =  Month.October,
                    PruningEnd  = Month.February,
                    FertilizingStart = Month.March,
                    FertilizingEnd = Month.October,
                    PHMin = 6.0f,
                    PHMax = 7f,
                    TemperatureMin = -30,
                    TemperatureMax = 30
                },
                new PlantItem
                {
                    Id=2,
                    CommonName = "Apricot",
                    WaterCycle = 2,
                    PruningCycle = 365,
                    FertilizationCycle = 120,
                    Notes = "",
                    HarvestStart = Month.July,
                    HarvestEnd  = Month.August,
                    PruningStart =  Month.November,
                    PruningEnd  = Month.February,
                    FertilizingStart = Month.March,
                    FertilizingEnd = Month.October,
                    PHMin = 6.0f,
                    PHMax = 7.5f,
                    TemperatureMin = -30,
                    TemperatureMax = 35
                },
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