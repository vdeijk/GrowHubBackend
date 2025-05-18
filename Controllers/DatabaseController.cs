using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly Seeder _seeder;
        private readonly ILogger<DatabaseController> _logger;

        public DatabaseController(Seeder seeder, ILogger<DatabaseController> logger)
        {
            _seeder = seeder;
            _logger = logger;
        }

        [HttpPost("seed")]
        public async Task<IActionResult> SeedDatabase()
        {
            try
            {
                _logger.LogInformation("Manual database seeding started");
                await _seeder.SeedAllData();
                return Ok(new { message = "Database seeded successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during database seeding");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}