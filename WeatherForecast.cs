using System;

namespace crappy_asp
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public override string ToString() => $"On {Date} it looks like a {Summary} day with a high of {TemperatureC} degrees."; 
    }
}
