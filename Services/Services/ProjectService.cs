using DAL.Models;
using DAL.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;

namespace Services.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await _projectRepository.GetAllAsync();
        }

        public async Task<Project> GetProjectByIdAsync(int id)
        {
            return await _projectRepository.GetByIdAsync(id);
        }
        public async Task CreateProjectAsync(Project project)
        {
            await _projectRepository.AddAsync(project);
        }

        public async Task UpdateProjectAsync(Project project)
        {
            await _projectRepository.UpdateAsync(project);
        }

        public async Task DeleteProjectAsync(int id)
        {
            await _projectRepository.DeleteAsync(id);
        }

    }
}
