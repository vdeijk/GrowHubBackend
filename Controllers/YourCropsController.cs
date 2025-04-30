using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Data;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class YourCropsController : ControllerBase
    {
        private readonly ILogger<YourCropsController> _logger;

        public YourCropsController(ILogger<YourCropsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCrops")]
        public IEnumerable<YourCropItem> Get()
        {
            _logger.LogInformation("Fetching all crops");
            return YourCropMockData.GetCrops();
        }

        [HttpGet("{id}")]
        public ActionResult<YourCropItem> Get(int id)
        {
            var plant = YourCropMockData.GetCropById(id);
            if (plant == null)
            {
                return NotFound();
            }
            return plant;
        }

        [HttpPost]
        public IActionResult Post([FromBody] YourCropItem plant)
        {
            YourCropMockData.AddCrop(plant);
            return CreatedAtAction(nameof(Get), new { id = plant.Id }, plant);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] YourCropItem updatedPlant)
        {
            var plant = YourCropMockData.GetCropById(id);
            if (plant == null)
            {
                return NotFound();
            }

            YourCropMockData.UpdateCrop(id, updatedPlant);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var plant = YourCropMockData.GetCropById(id);
            if (plant == null)
            {
                return NotFound();
            }

            YourCropMockData.DeleteCrop(id);
            return NoContent();
        }
    }
}