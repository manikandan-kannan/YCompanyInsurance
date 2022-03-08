using InsuranceClaim.API.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim.API.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly ILogger<WeatherForecastService> _logger;

        public WeatherForecastService(ILogger<WeatherForecastService> logger)
        {
            _logger = logger;
        }

        public string[] GetForecast()
        {
            try
            {
                _logger.LogInformation("log info", "Forecast");
                _logger.LogDebug("log debug", "Debug");

                var summaries = new[]
                {
                     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
                };

                if (summaries.Length > 0)
                {
                    throw new Exception("Invalid CAll");
                }
                return summaries;

            }
            catch (Exception e)
            {

                _logger.LogError(e, "error");
            }
            return null;
        }
    }
}

