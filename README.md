# 🌐 Developer Portfolio & PortfolioAPI  
*by Nylegna Kir Sosobrado*

This project is divided into two main components:

- 🖥️ **Portfolio** – A modern, responsive developer portfolio built using Razor Pages (.NET 9)
- 🔌 **PortfolioAPI** – A RESTful .NET 9 Web API that supplies structured project data for dynamic display on the portfolio site

---

## 🧰 Tech Stack Overview

### 🔷 Portfolio (Frontend – Razor Pages)
- Built with **ASP.NET Core Razor Pages** (.NET 9)
- Utilizes **C#, HTML, CSS**, and **Bootstrap Icons**
- Modular layout using **partial views** and sections
- Connects to the API via `HttpClient` and displays project cards dynamically
- Responsive UI optimized for accessibility and usability

### 🔷 PortfolioAPI (Backend – Web API)
- Built with **ASP.NET Core Web API** (.NET 9)
- Uses **Entity Framework Core (Code First)** with SQL Server
- Exposes one main endpoint:
  - `GET /api/projects` – returns all registered projects
- Includes **Swagger UI** for testing and interactive documentation
- Seeded with example project data via `SeedData.cs`

---

## 📁 Project API – Data Structure

### Project Model (C#)
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
