using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Services.Interfaces;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReadingController : ControllerBase
    {
        private readonly ILogger<ReadingController> _logger;
        private readonly IReadingRepo _readingRepo;

        public ReadingController(ILogger<ReadingController> logger, IReadingRepo plantRepo)
        {
            _logger = logger;
            _readingRepo = plantRepo;
        }

        [HttpGet(Name = "GetReadings")]
        public async Task<ActionResult<IEnumerable<ReadingItem>>> Get()
        {
            _logger.LogInformation("Fetching all readings");
            return Ok(await _readingRepo.GetAllReadings());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadingItem>> Get(Guid id)
        {
            var reading = await _readingRepo.GetReadingById(id);
            if (reading == null)
            {
                return NotFound();
            }
            return reading;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ReadingItem crop)
        {
            await _readingRepo.AddReading(crop);
            return CreatedAtAction(nameof(Get), new { id = crop.Id }, crop);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] ReadingItem updatedReading)
        {
            var existingPlant = await _readingRepo.GetReadingById(id);
            if (existingPlant == null)
            {
                return NotFound();
            }

            updatedReading.Id = id;
            await _readingRepo.UpdateReading(id, updatedReading);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var plant = await _readingRepo.GetReadingById(id);
            if (plant == null)
            {
                return NotFound();
            }

            await _readingRepo.DeleteReading(id);
            return NoContent();
        }
    }
}