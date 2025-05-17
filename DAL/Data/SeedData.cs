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
                        TechStack = "C#, ASP.NET Core, Razor Pages, Entity Framework Core, SQL Server, ASP.NET Identity, AutoMapper, HTML, CSS, Bootstrap, JavaScript, AJAX",
                        Description = "An internal banking system for managing customers, accounts, and transactions. Built with Razor Pages using a Database-First approach, secure authentication and role-based access (Admin & Cashier), and asynchronous transaction loading via AJAX. The UI is based on a customized free Bootstrap template adapted to a modern banking interface.",
                        CreatedDate = new DateTime(2025, 4, 10),
                        GithubUrl = "https://github.com/nellysosobrado/BankApplication.git",
                        LiveDemoUrl = "",
                        ImageUrl = "/images/Bank.png"
                    }
,
                    new Project
                    {
                        Name = "Ads API",
                        TechStack = "C#, ASP.NET Core 9.0, Web API, EF Core, SQL Server",
                        Description = "A RESTful API for managing classified ads, inspired by Blocket. Implements full CRUD and HTTP PATCH support.",
                        CreatedDate = new DateTime(2025, 5, 1),
                        GithubUrl = "https://github.com/nellysosobrado/Ad_API.git",
                        LiveDemoUrl = "",
                        ImageUrl = "/images/AD.png"
                    },
                    new Project
                    {
                        Name = "Portfolio",
                        TechStack = "C#, ASP.NET Core 9.0, Razor Pages, Entity Framework Core, REST API, Bootstrap 5, JavaScript, Swiper.js, Azure App Service",
                        Description = "A developer portfolio site built with Razor Pages. Displays previous projects by consuming a custom-built .NET REST API. Includes sections such as About Me, Skills, Projects, References, and Contact. Hosted on Azure.",
                        CreatedDate = new DateTime(2025, 5, 15),
                        GithubUrl = "",
                        LiveDemoUrl = "t",
                        ImageUrl = "/images/Portfolio.png"
                    },
                    new Project
                    {
                        Name = "Silicon Website",
                        TechStack = "JavaScript, React, HTML, CSS, Axios, AOS, React Router, Web API, LocalStorage, Git, GitHub, Figma",
                        Description = "A modern single-page website built in React, based on a UI design created in Figma. Features include light/dark theme toggle with local storage, fully component-based structure, API integration for testimonials, FAQs and newsletter subscription, scroll animations using AOS, and a fully responsive layout for all screen sizes.",
                        CreatedDate = new DateTime(2025, 5, 20),
                        GithubUrl = "https://github.com/nellysosobrado/Website-with-React.git",
                        LiveDemoUrl = "",
                        ImageUrl = "/images/silicon.png"
                    },
                    new Project
                    {
                        Name = "ConsoleApp Multi Feature",
                        TechStack = "C#, .NET Core, Entity Framework Core, Code First, SQL Server, OOP, Strategy Pattern, Dependency Injection (Autofac), FluentValidation, Spectre.Console, Soft Delete, Git, GitHub",
                        Description = "A .NET Core console application using Entity Framework Core (Code First) with SQL Server to manage shapes, calculator operations, and a Rock-Paper-Scissors game. Implements CRUD functionality with soft delete, object-oriented architecture, strategy pattern for calculations, and dependency injection using Autofac. Spectre.Console is used for an enhanced terminal interface, and FluentValidation ensures robust input validation. Includes clean code structure, color-coded UI, and data persistence.",
                        CreatedDate = new DateTime(2025, 1, 16),
                        GithubUrl = "https://github.com/nellysosobrado/EFCore_ConsoleApp_MultiFeature.git",
                        LiveDemoUrl = "",
                        ImageUrl = "/images/ClassLibraries.png"
                    }


                );

                context.SaveChanges();
            }
        }
    }
}
