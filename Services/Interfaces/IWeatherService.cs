
using Shared.External;

namespace Services.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherInfo?> GetWeatherAsync(string city = "Stockholm");
    }
}
