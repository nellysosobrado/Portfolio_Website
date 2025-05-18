# Portfolio website 

This is my personal developer portfolio, created to showcase my technical skills, background, and previous projects. The solution consists of three main projects:

- **Portfolio** – A responsive web application built with ASP.NET Razor Pages. It includes a real-time weather integration using the OpenWeatherMap API, demonstrating the use of external APIs in a modern web environment.

- **PortfolioAPI** – A .NET 8 REST API built with ASP.NET Core Web API. It delivers structured project data (name, tech stack, description, creation date, etc.). The API uses Entity Framework Core (Code First) to store data in a SQL Server database. It is deployed to Azure and consumed by the Portfolio frontend.

- **DAL (Data Access Layer)** – A class library that handles database access logic using Entity Framework Core. This promotes clean architecture, separation of concerns, and maintainability.

## Live Demo

- Portfolio: https://portfolionylegna-duhegge3eph2eve9.swedencentral-01.azurewebsites.net/
- API (SWAGGER): https://portfolioapi20250517155004-a3abhtfaecf6ekdh.swedencentral-01.azurewebsites.net/swagger/index.html

## Project Features

The portfolio includes:

- Hero section with portrait and personal introduction  
- "About Me" section  
- "Skills" section listing technical competencies  
- "Portfolio" section displaying projects dynamically from the API  
- "References" section presenting professional and academic references  
- Contact form with validation  
- Downloadable CV button  
- Links to GitHub and social media  
- Weather component showing current conditions using OpenWeatherMap  
- Footer with contact details  
- Responsive design and layout using **Bootstrap**  
- Smooth scroll-based animations implemented with **AOS (Animate On Scroll)** for enhanced user experience

  ## Key Features

- Dynamic project section (fetched from API)  
- Contact form with validation  
- Downloadable resume  
- Real-time weather widget  
- Mobile-friendly design  
- Swagger UI for API testing  
- HTTP PATCH support for partial updates in the API

## NuGet Packages

- `Microsoft.EntityFrameworkCore`  
- `Microsoft.EntityFrameworkCore.SqlServer`  
- `Swashbuckle.AspNetCore`  
- `Microsoft.AspNetCore.JsonPatch`  
- `Microsoft.Extensions.Configuration`, `Logging`, `DependencyInjection`

