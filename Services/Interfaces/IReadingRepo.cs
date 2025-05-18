using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using Models.ViewModels;

namespace Services.Interfaces
{
    public interface IReadingRepo
    {
        Task<IEnumerable<ReadingItem>> GetAllReadings();
        Task<ReadingItem> GetReadingById(Guid id);
        Task AddReading(ReadingItem plant);
        Task UpdateReading(Guid id, ReadingItem plant);
        Task DeleteReading(Guid id);
    }
}