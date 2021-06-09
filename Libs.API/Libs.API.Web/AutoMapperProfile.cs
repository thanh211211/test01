using AutoMapper;
using Libs.API.Core;
using Libs.API.Core.DTO.WeatherForecast;

namespace Libs.API.Web
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<WeatherForecast, GetWeatherForecast>();
            CreateMap<AddWeatherForecast, WeatherForecast>();
        }
    }
}
