using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;

        public TodoController(ILogger<TodoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTodoItems")]
        public IEnumerable<TodoItem> Get()
        {
            return TodoMockData.GetTasks();
        }
    }
}


