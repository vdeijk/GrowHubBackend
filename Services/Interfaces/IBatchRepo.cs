using Models;

namespace Services.Interfaces
{
    public interface IBatchRepo
    {
        Task<IEnumerable<BatchItem>> GetAllBatches();
        Task<BatchItem> GetBatchById(Guid id);
        Task AddBatch(BatchItem plant);
        Task UpdateBatch(Guid id, BatchItem plant);
        Task DeleteBatch(Guid id);
    }
}