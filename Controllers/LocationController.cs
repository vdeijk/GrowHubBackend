using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILogger<LocationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<LocationItem> Get()
        {
            _logger.LogInformation("Fetching all locations");
            return LocationMockData.GetLocations();
        }

        [HttpGet("{id}")]
        public ActionResult<LocationItem> Get(int id)
        {
            var location = LocationMockData.GetLocationById(id);
            if (location == null)
            {
                return NotFound();
            }
            return location;
        }

        [HttpPost]
        public IActionResult Post([FromBody] LocationItem location)
        {
            LocationMockData.AddLocation(location);
            return CreatedAtAction(nameof(Get), new { id = location.Id }, location);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] LocationItem updatedLocation)
        {
            var location = LocationMockData.GetLocationById(id);
            if (location == null)
            {
                return NotFound();
            }

            LocationMockData.UpdateLocation(id, updatedLocation);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var location = LocationMockData.GetLocationById(id);
            if (location == null)
            {
                return NotFound();
            }

            LocationMockData.DeleteLocation(id);
            return NoContent();
        }
    }
}