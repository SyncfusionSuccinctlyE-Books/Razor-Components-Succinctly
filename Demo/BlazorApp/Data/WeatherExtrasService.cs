using System;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class WeatherExtrasService
    {
        private static readonly string[] WindTypes = new[]
        {
            "Strong", "Heavy", "Mild", "Chilly", "No wind", "Hurricane", "Bursts", "Gentle breeze"  
        };

        public Task<WeatherExtras> GetExtrasAsync(WeatherForecast forecast)
        {
            var rng = new Random();
            return Task.FromResult(new WeatherExtras
            {
                Forecast = forecast,
                Humidity = rng.Next(-20, 55),
                Wind = WindTypes[rng.Next(WindTypes.Length)]
            });
        }
    }
}
