namespace Portfolio.Models;

public class WeatherInfo
{
    public MainInfo Main { get; set; } = new();
    public List<WeatherDescription> Weather { get; set; } = new();
    public string Name { get; set; } = string.Empty;
}

public class MainInfo
{
    public float Temp { get; set; }
}

public class WeatherDescription
{
    public string Description { get; set; } = string.Empty;
}
