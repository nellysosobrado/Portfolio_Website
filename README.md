# 🌐 Developer Portfolio & PortfolioAPI  
*by Nylegna Kir Sosobrado*

This project is divided into two main components:

- 🖥️ **Portfolio** – A responsive, personal developer portfolio built with Razor Pages (.NET 9)
- 🔌 **PortfolioAPI** – A RESTful .NET 9 Web API that provides project data consumed by the portfolio frontend

---

## 🎯 Purpose

To present previous development projects, technical knowledge, and skills through a dynamic and professional portfolio site that consumes a custom-built Web API.

---

## 🧰 Tech Stack

### 🔷 Portfolio (Frontend – Razor Pages)

- **ASP.NET Core Razor Pages (.NET 9)**
- Partial views used for reusable layout and project components **follows DRY (Don't Repeat Yourself)**
- Fetches project data from the API using `HttpClient`
- Clean, responsive UI using HTML, CSS, and Bootstrap Icons
- Sections include: About Me, Skills, Projects, Contact, References

### 🔷 PortfolioAPI (Backend – .NET Web API)

- **ASP.NET Core Web API (.NET 9)**
- **Entity Framework Core** (Code First with SQL Server)
- Exposes:
  - `GET /api/projects` – Returns all portfolio projects
- **Swagger UI** enabled for testing and documentation
- Project data is seeded via `SeedData.cs`

---

## 📁 Project Model (API)

```csharp
public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string TechStack { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public string GithubUrl { get; set; }
    public string LiveDemoUrl { get; set; }
    public string? ImageUrl { get; set; }
}
