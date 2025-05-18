using System.Collections.Generic;
using System.Threading.Tasks;
using Models.ViewModels;

namespace Services.Interfaces
{
    public interface ICropRepo
    {
        Task<IEnumerable<CropItem>> GetAllCrops();
        Task<CropItem> GetCropById(Guid id);
        Task AddCrop(CropItem plant);
        Task UpdateCrop(Guid id, CropItem plant);
        Task DeleteCrop(Guid id);
    }
}