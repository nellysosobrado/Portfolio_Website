using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Json;
using Portfolio.Models;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _http;
        private readonly IConfiguration _config;

        public IndexModel(ILogger<IndexModel> logger, HttpClient http, IConfiguration config)
        {
            _logger = logger;
            _http = http;
            _config = config;
        }

        public List<ProjectViewModel> Projects { get; set; } = new();

        public async Task OnGetAsync()
        {
            try
            {
                var baseUrl = _config["ApiBaseUrl"];
                var url = $"{baseUrl}/api/projects";
                _logger.LogInformation($"Anropar API: {url}");

                var result = await _http.GetFromJsonAsync<List<ProjectViewModel>>(url);

                if (result != null)
                {
                    Projects = result;
                    _logger.LogInformation($"Hämtade {Projects.Count} projekt.");
                }
                else
                {
                    _logger.LogWarning("API svarade med null.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Misslyckades med att hämta projekt.");
                Projects = new List<ProjectViewModel>();
            }
        }


    }
}
