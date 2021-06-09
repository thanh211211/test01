using Halliburton.App.Core.SharedKernel;
using System;

namespace Libs.API.Core
{
    public class WeatherForecast: BaseEntity
    {
        public DateTime Date { get; set; } = DateTime.Now;

        public int TemperatureC { get; set; } = 0;

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; } = "";
    }
}
