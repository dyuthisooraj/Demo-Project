using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Domain.Abstractions;
using WeatherForecast.Domain.Models;


namespace WeatherForecast.Dal
{
    public class WeatherForecastRepository: IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        public WeatherForecast[] GetForecasts()
        {
            throw new NotImplementedException();
        }
    }
}
