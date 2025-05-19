using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.External;

namespace Portfolio.Components
{
    public class WeatherViewComponent : ViewComponent
    {
        private readonly IWeatherService _weatherService;

        public WeatherViewComponent(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            WeatherInfo? weather = await _weatherService.GetWeatherAsync();
            return View(weather); 
        }
    }
}
