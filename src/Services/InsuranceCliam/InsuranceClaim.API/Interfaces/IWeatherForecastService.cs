using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaim.API.Interfaces
{
    public interface IWeatherForecastService
    {
        string[] GetForecast();
    }
}
