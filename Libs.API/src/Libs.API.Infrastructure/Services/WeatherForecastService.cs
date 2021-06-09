using Libs.API.Core;
using System;
using System.Collections.Generic;
using Libs.API.Core.Interfaces;
using Halliburton.App.Core.Interfaces;
using System.Threading.Tasks;
using Halliburton.App.Core.SharedKernel;
using System.Linq;
using Libs.API.Core.Entities;
using Libs.API.Core.DTO.WeatherForecast;
using AutoMapper;

namespace Libs.API.Infrastructure.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public static List<WeatherForecast> WeatherForecasts = new List<WeatherForecast>{
            new WeatherForecast(){Id=1 },
            new WeatherForecast(){ Id=2, TemperatureC = 100}
        };
        private readonly IMapper _mapper;

        public WeatherForecastService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceReponse<List<GetWeatherForecast>>> Add(AddWeatherForecast weatherForecast)
        {
            var serviceResponse = new ServiceReponse<List<GetWeatherForecast>>();
            WeatherForecasts.Add(_mapper.Map<WeatherForecast>(weatherForecast));
            serviceResponse.Data = WeatherForecasts.Select(c => _mapper.Map<GetWeatherForecast>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceReponse<List<GetWeatherForecast>>> Delete(int id)
        {
            var serviceResponse = new ServiceReponse<List<GetWeatherForecast>>();
            try
            {
                WeatherForecast weather = WeatherForecasts.First(x => x.Id == id);
                WeatherForecasts.Remove(weather);

                serviceResponse.Data = WeatherForecasts.Select(c => _mapper.Map<GetWeatherForecast>(c)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceReponse<List<GetWeatherForecast>>> GetAllAsync()
        {
            var serviceResponse = new ServiceReponse<List<GetWeatherForecast>>();
            serviceResponse.Data = WeatherForecasts.Select(c => _mapper.Map<GetWeatherForecast>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceReponse<GetWeatherForecast>> GetByIdAsync(int id)
        {
            var serviceResponse = new ServiceReponse<GetWeatherForecast>();
            serviceResponse.Data = _mapper.Map<GetWeatherForecast>(WeatherForecasts.FirstOrDefault(x => x.Id == id));
            return serviceResponse;
        }

        public async Task<ServiceReponse<GetWeatherForecast>> Update(UpdateWeatherForecast updateWeatherForecast)
        {
            var serviceResponse = new ServiceReponse<GetWeatherForecast>();
            try
            {
                WeatherForecast weather = WeatherForecasts.FirstOrDefault(x => x.Id == updateWeatherForecast.Id);

                weather.Summary = updateWeatherForecast.Summary;

                serviceResponse.Data = _mapper.Map<GetWeatherForecast>(weather);
            }
            catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
