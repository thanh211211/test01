using System;
using System.Collections.Generic;
using System.Text;

namespace Libs.API.Core.DTO.WeatherForecast
{
    public class AddWeatherForecast
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

        public DateTime Date { get; set; } = DateTime.Now;

        public int TemperatureC { get; set; } = 0;

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; } = "";
    }
}
