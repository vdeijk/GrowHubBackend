using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using Models.ViewModels;

namespace Services.Interfaces
{
    public interface ITodoRepo
    {
        Task<IEnumerable<TodoItem>> GetAllTodos();
        Task<TodoItem> GetTodoById(Guid id);
        Task AddTodo(TodoItem plant);
        Task UpdateTodo(Guid id, TodoItem plant);
        Task DeleteTodo(Guid id);
    }
}