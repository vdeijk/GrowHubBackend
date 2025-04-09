namespace Models
{
    public static class TodoMockData
    {
        public static List<TodoItem> GetTasks()
        {
            return new List<TodoItem>
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

        }
    }
}


