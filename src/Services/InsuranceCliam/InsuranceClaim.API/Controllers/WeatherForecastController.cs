using InsuranceClaim.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            var summaries = _weatherForecastService.GetForecast();
            if (summaries != null && summaries.Length > 0)
            {
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = summaries[rng.Next(summaries.Length)]
                })
                .ToArray();
            }
            else
            {
                return null;
            }
        }
    }
}
