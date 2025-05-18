# Nylegna Kir Sosobrado - .NET Fullstack Developer Portfolio

This solution demonstrates my skills as a fullstack .NET developer. It includes a responsive web frontend built with ASP.NET Razor Pages, a REST API for managing portfolio projects, and a clean architecture with clearly separated responsibilities.

The REST API (`PortfolioAPI`) is connected to a SQL Server database hosted in Microsoft Azure.  
All project data is stored in the cloud and accessed using Entity Framework Core (Code First).

In addition to backend and cloud integration, this project also highlights my ability to design user-friendly and accessible web interfaces using modern UX/UI principles.



## Live Demo

- Portfolio (Frontend):  
  https://portfolionylegna-duhegge3eph2eve9.swedencentral-01.azurewebsites.net/

- API (Swagger UI):  
  https://portfolioapi20250517155004-a3abhtfaecf6ekdh.swedencentral-01.azurewebsites.net/swagger/index.html


## Solution Structure

The solution includes the following projects:

| Project                 | Description                                               |
|-------------------------|-----------------------------------------------------------|
| `Portfolio`             | Frontend using ASP.NET Razor Pages                        |
| `PortfolioAPI`          | REST API that provides project data                       |
| `Services`              | Business logic and external API integration               |
| `DAL` (Data Access)     | Database access using Entity Framework Core               |
| `Shared`                | Shared models (DTOs, mapping profiles)                    |

  ## Key Features

- **Modern and responsive design**
  - Razor Pages frontend with accessible layout
  - "Load more" project functionality with pagination

- **Backend powered by a custom REST API**
  - Full CRUD functionality (Create, Read, Update, Delete)
  - Supports partial updates via JSON Patch (`PATCH`)
  - Projects are fetched from an internal API (`PortfolioAPI`)
  - Swagger 


- **Cloud database integration**
  - Uses Microsoft Azure SQL Database
  - Entity Framework Core (Code First)

- **Weather API integration**
  - Live weather displayed in the navigation bar (OpenWeather API)

- **Clean and modular architecture**
  - Separation of concerns between UI, services, API, and data
  - Shared project for DTOs and reusable data models

- **Object-Oriented Programming (OOP)**
  - Interface-based services and abstraction layers
  - Encapsulated logic using services and repositories

- **DRY Principle**
  - Shared services, models, and components to avoid repetition

- **AutoMapper**
  - Maps between entities and DTOs automatically

- **Reusable UI with Razor View Components**
  - Weather and project display are modular and maintainable

## Languages & Tools

- **Languages:**  
  C#, HTML, CSS, JavaScript, JSON

- **Frameworks & Platforms:**  
  ASP.NET Core, Razor Pages, .NET 9, Entity Framework Core

- **Databases & Cloud:**  
  Microsoft SQL Server (Azure), Azure App Service

- **APIs:**  
  Custom REST API (`PortfolioAPI`), OpenWeather API

- **Development Tools:**  
  Visual Studio 2022, Git, GitHub

- **Documentation & Testing:**  
  Swagger (OpenAPI)


## Languages & Tools

- **Languages:**  
  C#, HTML, CSS, JavaScript, JSON

- **Frameworks & Platforms:**  
  ASP.NET Core, Razor Pages, .NET 9, Entity Framework Core

- **Databases & Cloud:**  
  Microsoft SQL Server (Azure), Azure App Service, SQL Server Management Studio (SSMS)

- **APIs:**  
  Custom REST API (`PortfolioAPI`), OpenWeather API

- **Development Tools:**  
  Visual Studio 2022, Git, GitHub

- **Documentation & Testing:**  
  Swagger (OpenAPI)


## NuGet Packages Used

### Portfolio (Frontend)
- `Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation`
- `Microsoft.Extensions.Http`
- `Microsoft.Extensions.Options.ConfigurationExtensions`

### PortfolioAPI
- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`
- `AutoMapper.Extensions.Microsoft.DependencyInjection`
- `Swashbuckle.AspNetCore`
- `Microsoft.AspNetCore.JsonPatch`

### Portfolio.Services
- `Microsoft.Extensions.Http`
- `Microsoft.Extensions.Options`
- `System.Net.Http.Json`
- `AutoMapper`

### DAL
- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Design`

### Shared
- No external packages


