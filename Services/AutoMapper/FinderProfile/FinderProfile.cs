using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Finder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.AutoMapper.FinderProfile
{
    public class FinderProfile : Profile
    {
        public FinderProfile()
        {
            CreateMap<FinderViewDto, Finder>().ReverseMap();
        }
    }
}
