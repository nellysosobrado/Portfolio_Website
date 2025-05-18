using Portfolio.Models;

namespace Portfolio.Services
{
    public class ProjectDataService : IProjectDataService
    {
        private readonly HttpClient _httpClient;

        public ProjectDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProjectViewModel>> GetAllProjectsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ProjectViewModel>>("api/projects") ?? [];
        }

        public async Task<ProjectViewModel?> GetProjectByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProjectViewModel>($"api/projects/{id}");
        }
    }
}
