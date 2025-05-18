using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Data;
using Models;
using Data.Repositories;
using Models.ViewModels;
using Services.Interfaces;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BatchController : ControllerBase
    {
        private readonly ILogger<BatchController> _logger;
        private readonly IBatchRepo _batchRepo;

        public BatchController(ILogger<BatchController> logger, IBatchRepo batchRepo)
        {
            _logger = logger;
            _batchRepo = batchRepo;
        }

        [HttpGet(Name = "GetBatches")]
        public async Task<ActionResult<IEnumerable<BatchItem>>> Get()
        {
            _logger.LogInformation("Fetching all batches");
            return Ok(await _batchRepo.GetAllBatches());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BatchItem>> Get(Guid id)
        {
            var batch = await _batchRepo.GetBatchById(id);
            if (batch == null)
            {
                return NotFound();
            }
            return batch;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BatchItem batch)
        {
            await _batchRepo.AddBatch(batch);
            return CreatedAtAction(nameof(Get), new { id = batch.Id }, batch);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] BatchItem updatedBatch)
        {
            var batch = await _batchRepo.GetBatchById(id);
            if (batch == null)
            {
                return NotFound();
            }

            updatedBatch.Id = id;
            await _batchRepo.UpdateBatch(id, updatedBatch);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var plant = await _batchRepo.GetBatchById(id);
            if (plant == null)
            {
                return NotFound();
            }

            await _batchRepo.DeleteBatch(id);
            return NoContent();
        }
    }
}