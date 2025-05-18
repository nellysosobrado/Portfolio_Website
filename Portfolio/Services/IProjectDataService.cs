using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IProjectDataService
    {
        Task<IEnumerable<ProjectViewModel>> GetAllProjectsAsync();
        Task<ProjectViewModel?> GetProjectByIdAsync(int id);
    }
}
