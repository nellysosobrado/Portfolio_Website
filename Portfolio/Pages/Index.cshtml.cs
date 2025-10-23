using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;
using System.Net.Http.Json;

public class IndexModel : PageModel
{
    private readonly HttpClient _httpClient;
    public List<ProjectDto> Projects { get; set; } = new();

    public IndexModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task OnGetAsync()
    {
        Projects = await _httpClient.GetFromJsonAsync<List<ProjectDto>>(
            "https://portfolioapi-fagrd3gvh0g9frbw.swedencentral-01.azurewebsites.net/api/Projects"
        ) ?? new List<ProjectDto>();
    }
}
