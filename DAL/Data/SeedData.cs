using DAL.Models;

namespace DAL.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                    new Project
                    {
                        Name = "BankApp",
                        TechStack = "ASP.NET, Razor Pages, SQL Server",
                        Description = "Bankapplikation med kontoöversikt och transaktioner",
                        CreatedDate = new DateTime(2025, 4, 10),
                        GithubUrl = "https://github.com/dittkonto/bankapp",
                        LiveDemoUrl = "https://dindemo.azurewebsites.net",
                        ImageUrl = "/images/Nelly.jpg"
                    },
                    new Project
                    {
                        Name = "Annons API",
                        TechStack = "ASP.NET Web API, EF Core",
                        Description = "REST-API för annonser",
                        CreatedDate = new DateTime(2025, 5, 1),
                        GithubUrl = "https://github.com/dittkonto/annons-api",
                        LiveDemoUrl = "",
                        ImageUrl = "/images/Nelly.jpg"
                    }
                );

                context.SaveChanges();
            }
        }
    }

}
