using Microsoft.VisualBasic;

namespace Models
{
    public static class TodoMockData
    {
        private static List<TodoItem> _todos = new List<TodoItem>
            {
                new TodoItem
                {
                    Id = 1,
                    Title = "Task 1",
                    DueDate = new DateTime(2023, 12, 1),
                    Priority = "high",
                    IsCompleted = false,
                    Category = "work",
                    Description = "This is a description for task 1"
                },
                new TodoItem
                {
                    Id = 2,
                    Title = "Task 2",
                    DueDate = new DateTime(2023, 12, 5),
                    Priority = "medium",
                    IsCompleted = false,
                    Category = "work",
                    Description = "This is a description for task 2"
                },
                new TodoItem
                {
                    Id = 3,
                    Title = "Task 3",
                    DueDate = new DateTime(2023, 12, 10),
                    Priority = "low",
                    IsCompleted = true,
                    Category = "work",
                    Description = "This is a description for task 3"
                }
            };

        public static IEnumerable<TodoItem> GetTodos()
        {
            return _todos;
        }

        public static TodoItem GetTodoById(int id)
        {
            return _todos.Find(location => location.Id == id);
        }

        public static void AddTodo(TodoItem location)
        {
            location.Id = _todos.Count > 0 ? _todos[^1].Id + 1 : 1;
            _todos.Add(location);
        }

        public static void UpdateTodo(int id, TodoItem updateTodo)
        {
            var todo = _todos.Find(l => l.Id == id);
            if (todo != null)
            {
                todo.Id = updateTodo.Id;
                todo.Title = updateTodo.Title;
                todo.DueDate = updateTodo.DueDate;
                todo.Priority = updateTodo.Priority;
                todo.IsCompleted = updateTodo.IsCompleted;
                todo.Category = updateTodo.Category;
                todo.Description = updateTodo.Description;
            }
        }

        public static void DeleteTodo(int id)
        {
            _todos.RemoveAll(location => location.Id == id);
        }
    }
}

