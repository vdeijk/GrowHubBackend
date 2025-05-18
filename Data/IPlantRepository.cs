
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using Models.ViewModels;

namespace Data
{
    public interface IPlantRepository
    {
        Task<IEnumerable<PlantItem>> GetAllPlantsAsync();
        Task<PlantItem> GetPlantByIdAsync(string id);
        Task CreatePlantAsync(PlantItem plant);
        Task UpdatePlantAsync(string id, PlantItem plant);
        Task DeletePlantAsync(string id);
    }
}