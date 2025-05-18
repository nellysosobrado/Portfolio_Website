using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.External
{
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
}
