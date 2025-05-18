using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Models;
using Models.ViewModels;
using Services.Interfaces;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FieldController : ControllerBase
    {
        private readonly ILogger<FieldController> _logger;
        private readonly IFieldRepo _fieldRepo;

        public FieldController(ILogger<FieldController> logger, IFieldRepo fieldRepo)
        {
            _logger = logger;
            _fieldRepo = fieldRepo;
        }


        [HttpGet(Name = "GetFields")]
        public async Task<ActionResult<IEnumerable<FieldItem>>> Get()
        {
            _logger.LogInformation("Fetching all fields");
            return Ok(await _fieldRepo.GetAllFields());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FieldItem>> Get(Guid id)
        {
            var field = await _fieldRepo.GetFieldById(id);
            if (field == null)
            {
                return NotFound();
            }
            return field;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FieldItem field)
        {
            await _fieldRepo.AddField(field);
            return CreatedAtAction(nameof(Get), new { id = field.Id }, field);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] FieldItem updatedfield)
        {
            var existingPlant = await _fieldRepo.GetFieldById(id);
            if (existingPlant == null)
            {
                return NotFound();
            }

            updatedfield.Id = id;
            await _fieldRepo.UpdateField(id, updatedfield);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var plant = await _fieldRepo.GetFieldById(id);
            if (plant == null)
            {
                return NotFound();
            }

            await _fieldRepo.DeleteField(id);
            return NoContent();
        }
    }
}