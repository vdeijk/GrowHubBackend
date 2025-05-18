using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Models.ViewModels;
using MongoDB.Driver;
using Services.Interfaces;

namespace Models
{
    public class FieldRepo : IFieldRepo
    {
        private readonly IMongoCollection<FieldItem> _fieldCollection;

        public FieldRepo(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);
            _fieldCollection = mongoDatabase.GetCollection<FieldItem>(
                mongoDbSettings.Value.FieldsCollectionName);
        }

        public async Task<IEnumerable<FieldItem>> GetAllFields()
        {
            return await _fieldCollection.Find(_ => true).ToListAsync();
        }

        public async Task<FieldItem> GetFieldById(Guid id)
        {
            return await _fieldCollection.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddField(FieldItem field)
        {
            await _fieldCollection.InsertOneAsync(field);
        }

        public async Task UpdateField(Guid id, FieldItem updatedField)
        {
            updatedField.Id = id;
            await _fieldCollection.ReplaceOneAsync(p => p.Id == id, updatedField);
        }

        public async Task DeleteField(Guid id)
        {
            await _fieldCollection.DeleteOneAsync(p => p.Id == id);
        }
    }
}