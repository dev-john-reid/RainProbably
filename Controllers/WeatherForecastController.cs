using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RainProbably.Models.APP.Weather;
using RainProbably.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RainProbably.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IForecastService _forecastService;

        public WeatherForecastController(IForecastService forecastService)
        {
            _forecastService = forecastService;
        }

        [HttpGet]
        public IEnumerable<Forecast> Get()
        {
            Console.WriteLine("Fetching forecast...");
            Response res = _forecastService.Get();
            Console.WriteLine("Forecast retrieved!");
            return res.Weather;
        }
    }
}
