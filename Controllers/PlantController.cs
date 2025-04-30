using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Data;
using Models.ViewModels;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlantController : ControllerBase
    {
        private readonly ILogger<PlantController> _logger;

        public PlantController(ILogger<PlantController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPlants")]
        public IEnumerable<PlantItem> Get()
        {
            _logger.LogInformation("Fetching all plants");
            return PlantMockData.GetPlants();
        }

        [HttpGet("{id}")]
        public ActionResult<PlantItem> Get(int id)
        {
            var plant = PlantMockData.GetPlantById(id);
            if (plant == null)
            {
                return NotFound();
            }
            return plant;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PlantItem plant)
        {
            PlantMockData.AddPlant(plant);
            return CreatedAtAction(nameof(Get), new { id = plant.Id }, plant);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PlantItem updatedPlant)
        {
            var plant = PlantMockData.GetPlantById(id);
            if (plant == null)
            {
                return NotFound();
            }

            PlantMockData.UpdatePlant(id, updatedPlant);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var plant = PlantMockData.GetPlantById(id);
            if (plant == null)
            {
                return NotFound();
            }

            PlantMockData.DeletePlant(id);
            return NoContent();
        }
    }
}