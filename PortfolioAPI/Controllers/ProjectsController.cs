using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using DAL.Models;
using PortfolioAPI.DTOs;
using Services.Interfaces;

namespace PortfolioAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectService _projectService;
    private readonly IMapper _mapper;

    public ProjectsController(IProjectService projectService, IMapper mapper)
    {
        _projectService = projectService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProjectDto>>> GetProjects()
    {
        var projects = await _projectService.GetAllProjectsAsync();
        var result = _mapper.Map<List<ProjectDto>>(projects);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProjectDto>> GetProject(int id)
    {
        var project = await _projectService.GetProjectByIdAsync(id);
        if (project == null)
            return NotFound();

        var result = _mapper.Map<ProjectDto>(project);
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<ProjectDto>> CreateProject([FromBody] CreateProjectDto dto)
    {
        var project = _mapper.Map<Project>(dto);
        project.CreatedDate = DateTime.UtcNow;

        await _projectService.CreateProjectAsync(project);

        var result = _mapper.Map<ProjectDto>(project);
        return CreatedAtAction(nameof(GetProject), new { id = result.Id }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProject(int id, [FromBody] CreateProjectDto dto)
    {
        var existing = await _projectService.GetProjectByIdAsync(id);
        if (existing == null)
            return NotFound();

        _mapper.Map(dto, existing);
        await _projectService.UpdateProjectAsync(existing);

        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchProject(int id, [FromBody] JsonPatchDocument<CreateProjectDto> patchDoc)
    {
        if (patchDoc == null)
            return BadRequest();

        var project = await _projectService.GetProjectByIdAsync(id);
        if (project == null)
            return NotFound();

        var dto = _mapper.Map<CreateProjectDto>(project);
        patchDoc.ApplyTo(dto, ModelState);

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        _mapper.Map(dto, project);
        await _projectService.UpdateProjectAsync(project);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProject(int id)
    {
        var project = await _projectService.GetProjectByIdAsync(id);
        if (project == null)
            return NotFound();

        await _projectService.DeleteProjectAsync(id);

        return NoContent();
    }
}
