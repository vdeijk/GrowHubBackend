using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Data;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasurementsController : ControllerBase
    {
        private readonly ILogger<MeasurementsController> _logger;

        public MeasurementsController(ILogger<MeasurementsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMeasurements")]
        public IEnumerable<MeasurementItem> Get()
        {
            _logger.LogInformation("Fetching all measurements");
            return MeasurementsMockData.GetMeasurements();
        }

        [HttpGet("{id}")]
        public ActionResult<MeasurementItem> Get(int id)
        {
            var plant = MeasurementsMockData.GetMeasurementById(id);
            if (plant == null)
            {
                return NotFound();
            }
            return plant;
        }

        [HttpPost]
        public IActionResult Post([FromBody] MeasurementItem plant)
        {
            MeasurementsMockData.AddMeasurement(plant);
            return CreatedAtAction(nameof(Get), new { id = plant.Id }, plant);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MeasurementItem updatedPlant)
        {
            var plant = MeasurementsMockData.GetMeasurementById(id);
            if (plant == null)
            {
                return NotFound();
            }

            MeasurementsMockData.UpdateMeasurement(id, updatedPlant);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var plant = MeasurementsMockData.GetMeasurementById(id);
            if (plant == null)
            {
                return NotFound();
            }

            MeasurementsMockData.DeleteMeasurement(id);
            return NoContent();
        }
    }
}