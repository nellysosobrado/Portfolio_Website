# Portfolio

This solution demonstrates my skills as a fullstack .NET developer. It includes a responsive web frontend built with ASP.NET Razor Pages, a REST API for managing portfolio projects, and a clean architecture with clearly separated responsibilities.

The REST API (PortfolioAPI) is connected to a SQL Server database hosted in Microsoft Azure.
All project data is stored in the cloud and accessed using Entity Framework Core (Code First).

In addition to backend and cloud integration, this project also highlights my ability to design user-friendly and accessible web interfaces using modern UX/UI principles.

To ensure secure and flexible configuration, I use the appsettings.json system in ASP.NET Core. Sensitive data such as API keys and connection strings are stored outside the source code in configuration files. Environment-specific settings are separated using appsettings.Development.json for local development and appsettings.Production.json for deployment. This approach makes the application easier to maintain and safer to deploy to production.

## Live Demo

- Portfolio (Frontend):  
  [https://portfolio-nylegnakir-cdfkbch5d9hegeav.swedencentral-01.azurewebsites.net](https://portfolio-nylegnakirsosobrado-hmftdcayh4fjctdm.swedencentral-01.azurewebsites.net)
  
- PortfolioAPI (Swagger UI):  
   https://portfolioapi-fagrd3gvh0g9frbw.swedencentral-01.azurewebsites.net 



## Solution Structure

The solution includes the following projects:

| Project                 | Description                                               |
|-------------------------|-----------------------------------------------------------|
| `Portfolio`             | Frontend using ASP.NET Razor Pages                        |
| `PortfolioAPI`          | REST API that provides project data                       |
| `Services`              | Business logic and external API integration               |
| `DAL` (Data Access)     | Database access using Entity Framework Core               |
| `Shared`                | Shared models (DTOs, mapping profiles)                    |

![PortfolioFlowChart](https://github.com/user-attachments/assets/36fa3265-878e-4bae-b9f8-0ebee27aff99)

  ## Key Features

###  Modern, responsive design  
- Built with ASP.NET Razor Pages and mobile-friendly layout  
- “Load more” functionality for dynamic project loading

###  Custom REST API  
- Full CRUD support (Create, Read, Update, Delete, Patch)  
- Supports partial updates using `PATCH` (JSON Patch)  
- API via Swagger (OpenAPI)

###  Cloud-based database  
- SQL Server hosted in Microsoft Azure  
- Managed with Entity Framework Core using Code First and migrations

###  Weather API integration  
- Displays live weather in the navigation bar using OpenWeather API  
- API keys and settings are securely stored in `appsettings.json` with separate files for development and production

### Modular architecture  
- Clear separation between UI, services, API, and data layers  
- Shared project for reusable models and DTOs across the solution

###  OOP & SOLID principles  
- Interface-based services and dependency injection for loose coupling  
- Applies the Dependency Inversion Principle to keep code flexible and testable  
- Follows good object-oriented design practices

###  AutoMapper  
- Automatically maps between entities and DTOs  
- Reduces boilerplate code and simplifies data transformations

###  DRY & reusable components  
- Shared services and models used across the application to avoid duplication  
- Razor View Components for reusable and maintainable UI parts (weather, project listings)
 
##  Form Validation

The contact form on the homepage uses built-in **HTML5 validation attributes** (e.g. `required`, `type="email"`) to ensure valid input before the message is sent via EmailJS.

Validation is enforced directly in the browser using standard form controls. This includes:

- Required fields for name, email, and message
- Email format validation via `type="email"`
- Prevention of submission unless all fields are valid

This ensures:

- Immediate user feedback
- Valid and structured data sent to EmailJS
- A secure and user-friendly experience without server-side validation


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


