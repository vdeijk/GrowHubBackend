
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Models.ViewModels;
using System.Collections.Generic;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurnoverController : ControllerBase
    {
        private readonly ILogger<TurnoverController> _logger;

        public TurnoverController(ILogger<TurnoverController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTurnovers")]
        public IEnumerable<TurnoverItem> Get()
        {
            _logger.LogInformation("Fetching all turnovers");
            return TurnoverMockData.GetTurnovers();
        }
    }
}

