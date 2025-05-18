using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace PortfolioAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProjectsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchProject(int id, [FromBody] JsonPatchDocument<Project> patchDoc)
    {
        if (patchDoc == null)
            return BadRequest();

        var project = await _context.Projects.FindAsync(id);
        if (project == null)
            return NotFound();

        patchDoc.ApplyTo(project, ModelState);

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Projects.Any(p => p.Id == id))
                return NotFound();
            throw;
        }

        return NoContent();
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
    {
        return await _context.Projects.ToListAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Project>> GetProject(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
            return NotFound();
        return project;
    }


    [HttpPost]
    public async Task<ActionResult<Project>> CreateProject(Project project)
    {
        project.Id = 0; 

        _context.Projects.Add(project);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProject), new { id = project.Id }, project);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProject(int id, Project project)
    {
        if (id != project.Id)
            return BadRequest();

        _context.Entry(project).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Projects.Any(p => p.Id == id))
                return NotFound();
            throw;
        }

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
