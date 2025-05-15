namespace Portfolio.Models
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string TechStack { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime CreatedDate { get; set; }
        public string GithubUrl { get; set; } = "";
        public string LiveDemoUrl { get; set; } = "";
        public string? ImageUrl { get; set; }

    }
}
