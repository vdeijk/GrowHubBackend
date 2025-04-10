using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackendApp.Data;
using System.Collections.Generic;
using Models;

namespace BackendApp.Controllers
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
        public IEnumerable<Plant> Get()
        {
            _logger.LogInformation("Fetching all plants");
            return PlantMockData.GetPlants();
        }
    }
}