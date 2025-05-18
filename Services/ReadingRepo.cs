using Microsoft.Extensions.Options;
using Models.ViewModels;
using MongoDB.Driver;
using Services.Interfaces;

namespace Models
{
    public class ReadingRepo: IReadingRepo
    {
        private readonly IMongoCollection<ReadingItem> _readingCollection;

        public ReadingRepo(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);
            _readingCollection = mongoDatabase.GetCollection<ReadingItem>(
                mongoDbSettings.Value.ReadingsCollectionName);
        }

        public async Task<IEnumerable<ReadingItem>> GetAllReadings()
        {
            return await _readingCollection.Find(_ => true).ToListAsync();
        }

        public async Task<ReadingItem> GetReadingById(Guid id)
        {
            return await _readingCollection.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddReading(ReadingItem reading)
        {
            await _readingCollection.InsertOneAsync(reading);
        }

        public async Task UpdateReading(Guid id, ReadingItem updatedReading)
        {
            updatedReading.Id = id;
            await _readingCollection.ReplaceOneAsync(p => p.Id == id, updatedReading);
        }

        public async Task DeleteReading(Guid id)
        {
            await _readingCollection.DeleteOneAsync(p => p.Id == id);
        }
    }
}