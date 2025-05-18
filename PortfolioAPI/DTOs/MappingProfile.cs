using AutoMapper;
using DAL.Models;
using PortfolioAPI.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Visning
        CreateMap<Project, ProjectDto>();

        // Skapa/uppdatera
        CreateMap<CreateProjectDto, Project>();

        // PATCH-stöd
        CreateMap<Project, CreateProjectDto>();
    }
}
