using Microsoft.Extensions.Options;
using Models;
using MongoDB.Driver;
using Services.Interfaces;


namespace Data.Repositories
{
    public class BatchRepo: IBatchRepo
    {
        private readonly IMongoCollection<BatchItem> _batchesCollection;

        public BatchRepo(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);
            _batchesCollection = mongoDatabase.GetCollection<BatchItem>(
                mongoDbSettings.Value.BatchesCollectionName);
        }

        public async Task<IEnumerable<BatchItem>> GetAllBatches()
        {
            return await _batchesCollection.Find(_ => true).ToListAsync();
        }

        public async Task<BatchItem> GetBatchById(Guid id)
        {
            return await _batchesCollection.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddBatch(BatchItem batch)
        {
            await _batchesCollection.InsertOneAsync(batch);
        }

        public async Task UpdateBatch(Guid id, BatchItem updatedPlant)
        {
            updatedPlant.Id = id;
            await _batchesCollection.ReplaceOneAsync(p => p.Id == id, updatedPlant);
        }

        public async Task DeleteBatch(Guid id)
        {
            await _batchesCollection.DeleteOneAsync(p => p.Id == id);
        }
    }
}