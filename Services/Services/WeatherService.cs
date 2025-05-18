using Microsoft.Extensions.Options;
using Services.Interfaces;
using Shared.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public WeatherService(HttpClient httpClient, IOptions<OpenWeatherOptions> options)
        {
            _httpClient = httpClient;
            _apiKey = options.Value.ApiKey;
        }

        public async Task<WeatherInfo?> GetWeatherAsync(string city = "Stockholm")
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";
            return await _httpClient.GetFromJsonAsync<WeatherInfo>(url);
        }
    }
}
