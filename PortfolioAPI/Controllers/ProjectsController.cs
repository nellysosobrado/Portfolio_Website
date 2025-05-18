using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL.Data;
using DAL.Models;
using PortfolioAPI.DTOs;

namespace PortfolioAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public ProjectsController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProjectDto>>> GetProjects()
    {
        var projects = await _context.Projects.ToListAsync();
        var result = _mapper.Map<List<ProjectDto>>(projects);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProjectDto>> GetProject(int id)
    {
        var project = await _context.Projects.FindAsync(id);
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

        _context.Projects.Add(project);
        await _context.SaveChangesAsync();

        var result = _mapper.Map<ProjectDto>(project);
        return CreatedAtAction(nameof(GetProject), new { id = result.Id }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProject(int id, [FromBody] CreateProjectDto dto)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
            return NotFound();

        _mapper.Map(dto, project);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchProject(int id, [FromBody] JsonPatchDocument<CreateProjectDto> patchDoc)
    {
        if (patchDoc == null)
            return BadRequest();

        var project = await _context.Projects.FindAsync(id);
        if (project == null)
            return NotFound();

        var dto = _mapper.Map<CreateProjectDto>(project);
        patchDoc.ApplyTo(dto, ModelState);

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        _mapper.Map(dto, project);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProject(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
            return NotFound();

        _context.Projects.Remove(project);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}