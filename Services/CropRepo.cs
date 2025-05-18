using Microsoft.Extensions.Options;
using Models;
using Models.ViewModels;
using MongoDB.Driver;
using Services.Interfaces;

namespace Data.Repositories
{
    public class CropRepo : ICropRepo
    {
        private readonly IMongoCollection<CropItem> _cropsCollection;

        public CropRepo(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var settings = mongoDbSettings.Value;

            var mongoClient = new MongoClient(settings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(settings.DatabaseName);
            _cropsCollection = mongoDatabase.GetCollection<CropItem>(settings.CropsCollectionName);
        }

        public async Task<IEnumerable<CropItem>> GetAllCrops()
        {
            return await _cropsCollection.Find(_ => true).ToListAsync();
        }

        public async Task<CropItem> GetCropById(Guid id)
        {
            return await _cropsCollection.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddCrop(CropItem plant)
        {
            await _cropsCollection.InsertOneAsync(plant);
        }

        public async Task UpdateCrop(Guid id, CropItem updatedPlant)
        {
            updatedPlant.Id = id;
            await _cropsCollection.ReplaceOneAsync(p => p.Id == id, updatedPlant);
        }

        public async Task DeleteCrop(Guid id)
        {
            await _cropsCollection.DeleteOneAsync(p => p.Id == id);
        }
    }
}

