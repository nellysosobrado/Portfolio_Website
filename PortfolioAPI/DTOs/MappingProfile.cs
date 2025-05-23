using AutoMapper;
using DAL.Models;
using PortfolioAPI.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        CreateMap<Project, ProjectDto>();


        CreateMap<CreateProjectDto, Project>();


        CreateMap<Project, CreateProjectDto>();
    }
}
