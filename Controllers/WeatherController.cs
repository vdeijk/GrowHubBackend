using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("forecast")]
        public async Task<IActionResult> GetWeatherForecast([FromQuery] string city, int days)
        {
            try
            {
                var weatherData = await _weatherService.GetWeatherForecastAsync(city, days);
                return Ok(weatherData);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, $"Error fetching weather data: {ex.Message}");
            }
        }
    }
}