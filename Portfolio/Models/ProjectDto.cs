namespace Portfolio.Models
{
    public class ProjectDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? GithubUrl { get; set; }
        public string? DemoUrl { get; set; }
        public List<string>? Tags { get; set; }
    }
}
