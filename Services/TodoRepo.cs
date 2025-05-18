using Microsoft.Extensions.Options;
using Models;
using MongoDB.Driver;
using Services.Interfaces;

namespace Models
{
    public class TodoRepo: ITodoRepo
    {
        private readonly IMongoCollection<TodoItem> _todoCollection;

        public TodoRepo(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);
            _todoCollection = mongoDatabase.GetCollection<TodoItem>(
                mongoDbSettings.Value.TodosCollectionName);
        }

        public async Task<IEnumerable<TodoItem>> GetAllTodos()
        {
            return await _todoCollection.Find(_ => true).ToListAsync();
        }

        public async Task<TodoItem> GetTodoById(Guid id)
        {
            return await _todoCollection.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddTodo(TodoItem todo)
        {
            await _todoCollection.InsertOneAsync(todo);
        }

        public async Task UpdateTodo(Guid id, TodoItem updatedTodo)
        {
            updatedTodo.Id = id;
            await _todoCollection.ReplaceOneAsync(p => p.Id == id, updatedTodo);
        }

        public async Task DeleteTodo(Guid id)
        {
            await _todoCollection.DeleteOneAsync(p => p.Id == id);
        }
    }
}
