﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Domain.Models;

namespace WeatherForecast.Domain.Abstractions
{
    public interface IWeatherForecastRepository
    {
        //IWeatherForecastRepository[] Forecasts { get; }
        WeatherForecast[] GetWeatherForecasts(); 
    }
}
