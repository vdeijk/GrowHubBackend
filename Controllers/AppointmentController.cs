using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using System.Collections.Generic;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly ILogger<AppointmentController> _logger;

        public AppointmentController(ILogger<AppointmentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAppointments")]
        public IEnumerable<AppointmentItem> Get()
        {
            _logger.LogInformation("Fetching all appointments");
            return AppointmentMockData.GetAppointments();
        }
    }
}
