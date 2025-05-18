using Portfolio.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "d5806618a6f63df567aa2a329f966f43"; 

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherInfo?> GetWeatherAsync(string city = "Stockholm")
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";
            return await _httpClient.GetFromJsonAsync<WeatherInfo>(url);
        }
    }
}
