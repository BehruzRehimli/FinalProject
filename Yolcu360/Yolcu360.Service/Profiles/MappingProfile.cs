using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;

namespace Yolcu360.Service.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BrandCreateDto, Brand>();
            CreateMap<Brand, BrandGetDto>();
            CreateMap<Brand, BrandGetAllDto>();



            CreateMap<Brand, CreateResultDto>();
        }
    }
}
