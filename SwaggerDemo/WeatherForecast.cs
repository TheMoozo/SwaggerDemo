using System;

namespace SwaggerDemo
{
    public class WeatherForecast
    {
        /// <summary>
        /// Date of the Weather
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Weather Temperature in Celcius
        /// </summary>
        public int TemperatureC { get; set; }
        /// <summary>
        /// Weather Temperature in Fahrenheit
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        /// <summary>
        /// Basic Summary of Weather
        /// </summary>
        public string Summary { get; set; }
    }
}
