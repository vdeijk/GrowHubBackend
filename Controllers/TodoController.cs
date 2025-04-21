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
            return TodoMockData.GetTodos();
        }


        [HttpGet("{id}")]
        public ActionResult<TodoItem> Get(int id)
        {
            var location = TodoMockData.GetTodoById(id);
            if (location == null)
            {
                return NotFound();
            }
            return location;
        }

        [HttpPost]
        public IActionResult Post([FromBody] TodoItem todo)
        {
            TodoMockData.AddTodo(todo);
            return CreatedAtAction(nameof(Get), new { id = todo.Id }, todo);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TodoItem updatedLocation)
        {
            var todo = TodoMockData.GetTodoById(id);
            if (todo == null)
            {
                return NotFound();
            }

            TodoMockData.UpdateTodo(id, updatedLocation);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var location = TodoMockData.GetTodoById(id);
            if (location == null)
            {
                return NotFound();
            }

            TodoMockData.DeleteTodo(id);
            return NoContent();
        }
    }
}


