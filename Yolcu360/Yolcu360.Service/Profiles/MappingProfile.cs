using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Country;
using Yolcu360.Service.Dtos.Type;

namespace Yolcu360.Service.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BrandCreateDto, Brand>();
            CreateMap<Brand, BrandGetDto>();
            CreateMap<Brand, BrandGetAllDto>();
            CreateMap<TypeCreateDto,Yolcu360.Core.Entities.Type>();
            CreateMap<Yolcu360.Core.Entities.Type, TypeGetDto>();
            CreateMap<Yolcu360.Core.Entities.Type, TypeGetAllDto>();
            CreateMap<CountryCreateDto, Country>();
            CreateMap<Country, CountryGetDto>();
            CreateMap<Country, CountryGetAllDto>();

            CreateMap<Brand, CreateResultDto>();
            CreateMap<Core.Entities.Type, CreateResultDto>();
            CreateMap<Country, CreateResultDto>();
        }
    }
}
