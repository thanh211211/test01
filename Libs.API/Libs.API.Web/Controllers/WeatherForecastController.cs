using Libs.API.Core;
using Libs.API.Core.DTO.WeatherForecast;
using Libs.API.Core.Entities;
using Libs.API.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libs.API.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceReponse<List<GetWeatherForecast>>>> GetAll()
        {
            return Ok(await _weatherForecastService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceReponse<List<GetWeatherForecast>>>> GetById(int id)
        {
            return Ok(await _weatherForecastService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceReponse<List<GetWeatherForecast>>>> Add(AddWeatherForecast weatherForecast)
        {
            return Ok(await _weatherForecastService.Add(weatherForecast));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceReponse<GetWeatherForecast>>> Update(UpdateWeatherForecast weatherForecast)
        {
            var response = await _weatherForecastService.Update(weatherForecast);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceReponse<List<GetWeatherForecast>>>> Delete(int id)
        {
            var response = await _weatherForecastService.Delete(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok();
        }
    }
}
