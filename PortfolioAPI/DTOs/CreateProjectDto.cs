using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.DTOs
{
    public class CreateProjectDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string TechStack { get; set; }

        public string? Description { get; set; }
        public string? GithubUrl { get; set; }
        public string? LiveDemoUrl { get; set; }
        public string? ImageUrl { get; set; }
    }


}
