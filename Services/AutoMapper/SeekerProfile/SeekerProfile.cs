using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Seeker;

namespace Services.AutoMapper.SeekerProfile
{
    public class SeekerProfile : Profile
    {
        public SeekerProfile()
        {
            CreateMap<SeekerRegisterDto,Seeker>().ReverseMap();
            CreateMap<SeekerLoginDto,Seeker>().ReverseMap();
        }
    }
}
