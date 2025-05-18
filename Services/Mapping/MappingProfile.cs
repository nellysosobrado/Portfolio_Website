using AutoMapper;
using DAL.Models;
using Shared.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Services.Mapping;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
       
        CreateMap<Project, ProjectDto>();

     
        CreateMap<CreateProjectDto, Project>();

      
        CreateMap<Project, CreateProjectDto>();
    }
}
