using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using Portfolio.Models;

public class PortfolioModel : PageModel
{
    private readonly HttpClient _http;

    public PortfolioModel(IHttpClientFactory factory)
    {
        _http = factory.CreateClient();
    }

    public List<ProjectViewModel> Projects { get; set; } = new();

    public async Task OnGetAsync()
    {
        var apiUrl = "https://localhost:7253/api/projects";
        var result = await _http.GetFromJsonAsync<List<ProjectViewModel>>(apiUrl);
        if (result != null)
        {
            Projects = result;
        }
    }
}
