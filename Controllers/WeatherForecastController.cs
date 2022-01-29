using Microsoft.AspNetCore.Mvc;

namespace ExampleApps.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ICurrentUserService currentUserService;

        public WeatherForecastController(ICurrentUserService currentUserService)
        {
            this.currentUserService = currentUserService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(currentUserService.RemoteIpAddress);
        }
    }
}