using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _http;
        public IndexModel(ILogger<IndexModel> logger, HttpClient http)
        {
            _logger = logger;
            _http = http;
        }
        public List<ProjectViewModel> Projects { get; set; } = new();

        public async Task OnGetAsync()
        {
            var apiUrl = "https://localhost:7253/api/projects";
            var result = await _http.GetFromJsonAsync<List<ProjectViewModel>>(apiUrl);
            if (result != null)
                Projects = result;
        }

    }
}
