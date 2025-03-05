using AutoMapper;
using Portfolio.Application.DTOs;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<AboutMe, AboutMeDto>();
        CreateMap<Technology, TechnologyDto>();
        CreateMap<Project, ProjectDto>();
        CreateMap<Resume, ResumeDto>();
    }
}