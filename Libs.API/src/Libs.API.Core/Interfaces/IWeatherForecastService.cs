using Halliburton.App.Core.Interfaces;
using Libs.API.Core.DTO.WeatherForecast;
using Libs.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Libs.API.Core.Interfaces
{
    public interface IWeatherForecastService //: IRepository<WeatherForecast>
    {
        Task<ServiceReponse<List<GetWeatherForecast>>> GetAllAsync();
        Task<ServiceReponse<GetWeatherForecast>> GetByIdAsync(int id);
        Task<ServiceReponse<List<GetWeatherForecast>>> Add(AddWeatherForecast weatherForecast);
        Task<ServiceReponse<GetWeatherForecast>> Update(UpdateWeatherForecast weatherForecast);
        Task<ServiceReponse<List<GetWeatherForecast>>> Delete(int id);
    }
}
