using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Models.ViewModels;
using Services.Interfaces;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        private readonly ITodoRepo _todoRepo;

        public TodoController(ILogger<TodoController> logger, ITodoRepo todoRepo)
        {
            _logger = logger;
            _todoRepo = todoRepo;
        }

        [HttpGet(Name = "GetAllTodos")]
        public async Task<ActionResult<IEnumerable<TodoItem>>> Get()
        {
            _logger.LogInformation("Fetching all todos");
            return Ok(await _todoRepo.GetAllTodos());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> Get(Guid id)
        {
            var todo = await _todoRepo.GetTodoById(id);
            if (todo == null)
            {
                return NotFound();
            }
            return todo;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TodoItem todo)
        {
            await _todoRepo.AddTodo(todo);
            return CreatedAtAction(nameof(Get), new { id = todo.Id }, todo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] TodoItem updatedTodo)
        {
            var existingPlant = await _todoRepo.GetTodoById(id);
            if (existingPlant == null)
            {
                return NotFound();
            }

            updatedTodo.Id = id;
            await _todoRepo.UpdateTodo(id, updatedTodo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var plant = await _todoRepo.GetTodoById(id);
            if (plant == null)
            {
                return NotFound();
            }

            await _todoRepo.DeleteTodo(id);
            return NoContent();
        }
    }
}


