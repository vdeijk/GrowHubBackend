using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.ViewModels;
using Services.Interfaces;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CropController : ControllerBase
    {
        private readonly ILogger<CropController> _logger;
        private readonly ICropRepo _cropRepo;

        public CropController(ILogger<CropController> logger, ICropRepo cropRepo)
        {
            _logger = logger;
            _cropRepo = cropRepo;
        }

        [HttpGet(Name = "GetCrops")]
        public async Task<ActionResult<IEnumerable<CropItem>>> Get()
        {
            _logger.LogInformation("Fetching all crops");
            return Ok(await _cropRepo.GetAllCrops());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CropItem>> Get(Guid id)
        {
            var plant = await _cropRepo.GetCropById(id);
            if (plant == null)
            {
                return NotFound();
            }
            return plant;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CropItem plant)
        {
            await _cropRepo.AddCrop(plant);
            return CreatedAtAction(nameof(Get), new { id = plant.Id }, plant);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CropItem updatedPlant)
        {
            var existingPlant = await _cropRepo.GetCropById(id);
            if (existingPlant == null)
            {
                return NotFound();
            }

            updatedPlant.Id = id;
            await _cropRepo.UpdateCrop(id, updatedPlant);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var plant = await _cropRepo.GetCropById(id);
            if (plant == null)
            {
                return NotFound();
            }

            await _cropRepo.DeleteCrop(id);
            return NoContent();
        }
    }
}