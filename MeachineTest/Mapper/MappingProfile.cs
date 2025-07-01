using AutoMapper;
using MeachineTest.DTO;
using MeachineTest.Model; 
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<StudentRegistrationDto, Student>();
        CreateMap<QualificationDto, Qualification>();
    }
}
