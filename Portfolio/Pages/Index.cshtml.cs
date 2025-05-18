using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProjectDataService _projectDataService;

        public IndexModel(ILogger<IndexModel> logger, IProjectDataService projectDataService)
        {
            _logger = logger;
            _projectDataService = projectDataService;
        }

        public List<ProjectViewModel> Projects { get; set; } = new();

        public async Task OnGetAsync()
        {
            _logger.LogInformation("Loads starts page & API");
            Projects = (await _projectDataService.GetAllProjectsAsync()).ToList();
        }
    }
}
