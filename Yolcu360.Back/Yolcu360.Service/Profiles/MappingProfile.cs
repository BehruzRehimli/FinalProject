using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Service.Dtos.AboutCity;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Car;
using Yolcu360.Service.Dtos.City;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Country;
using Yolcu360.Service.Dtos.Model;
using Yolcu360.Service.Dtos.Office;
using Yolcu360.Service.Dtos.Type;
using Yolcu360.Service.Helpers;

namespace Yolcu360.Service.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BrandCreateDto, Brand>();
            CreateMap<Brand, BrandGetDto>();
            CreateMap<Brand, BrandGetAllDto>();
            CreateMap<ModelCreateDto, Model>();
            CreateMap<Model, ModelGetDto>();
            CreateMap<Model, ModelGetAllDto>();
            CreateMap<TypeCreateDto,Yolcu360.Core.Entities.Type>();
            CreateMap<Yolcu360.Core.Entities.Type, TypeGetDto>();
            CreateMap<Yolcu360.Core.Entities.Type, TypeGetAllDto>();
            CreateMap<CountryCreateDto, Country>();
            CreateMap<Country, CountryGetDto>();
            CreateMap<Country, CountryGetAllDto>();
            CreateMap<Country, CityGetAllCountry>();
            CreateMap<City, CityGetAllDto>()
                .ForMember(x => x.ImageName, s => s.MapFrom(m => BaseUrl.GetUrl("City") + m.ImageName));
            CreateMap<Country, CityGetCountry>();
            CreateMap<City, CityGetDto>()
                .ForMember(x=>x.ImageName,s=>s.MapFrom(m=>BaseUrl.GetUrl("City")+m.ImageName));
            CreateMap<CityCreateDto, City>();
            CreateMap<Office, OfficeGetAllDto>();
            CreateMap<Country, OfficeGetAllCountry>();
            CreateMap<City, OfficeGetAllCity>().
                ForMember(x => x.ImageName, s => s.MapFrom(m => BaseUrl.GetUrl("City") + m.ImageName));
            CreateMap<Country, OfficeGetCountry>();
            CreateMap<City, OfficeGetCity>().
                ForMember(x => x.ImageName, s => s.MapFrom(m => BaseUrl.GetUrl("City") + m.ImageName));
            CreateMap<Office, OfficeGetDto>();
            CreateMap<OfficeCreateDto, Office>();
            CreateMap<City, GetAboutCityDtoCity>();
            CreateMap<AboutCity, GetAboutCityDto>().
                ForMember(x=> x.ImageName, s=>s.MapFrom(m=> BaseUrl.GetUrl("AboutCity")+m.ImageName));
            CreateMap<City, GetAllAboutCityDtoCity>();
            CreateMap<AboutCity, GetAllAboutCityDto>().
                ForMember(x => x.ImageName, s => s.MapFrom(m => BaseUrl.GetUrl("AboutCity") + m.ImageName));
            CreateMap<CreateAboutCityDto, AboutCity>();
            CreateMap<AboutCity, OfficeGetAboutCity>().
                ForMember(x => x.ImageName, s => s.MapFrom(m=>m.ImageName!=null?BaseUrl.GetUrl("AboutCity") + m.ImageName:null));
            CreateMap<Office, OfficeSearchDto>();
            CreateMap<AppUser, CarGetAllDtoUser>();
            CreateMap<Review, CarGetAllDtoReview>();
            CreateMap<Country, CarGetAllDtoCountry>();
            CreateMap<City, CarGetAllDtoCity>();
            CreateMap<Office, CarGetAllDtoOffice>();
            CreateMap<Core.Entities.Type, CarGetAllDtoType>();
            CreateMap<Brand, CarGetAllDtoBrand>();
            CreateMap<Model, CarGetAllDtoModel>();
            CreateMap<Car, CarGetAllDto>().
                 ForMember(x => x.ImageName, s => s.MapFrom(m => m.ImageName != null ? BaseUrl.GetUrl("AboutCity") + m.ImageName : null));
            CreateMap<CarCreateDto, Car>();
            CreateMap<AppUser, CarGetDtoUser>();
            CreateMap<Review, CarGetDtoReview>();
            CreateMap<Country, CarGetDtoCountry>();
            CreateMap<City, CarGetDtoCity>();
            CreateMap<Office, CarGetDtoOffice>();
            CreateMap<Core.Entities.Type, CarGetDtoType>();
            CreateMap<Brand, CarGetDtoBrand>();
            CreateMap<Model, CarGetDtoModel>();
            CreateMap<Car, CarGetDto>().
                 ForMember(x => x.ImageName, s => s.MapFrom(m => m.ImageName != null ? BaseUrl.GetUrl("AboutCity") + m.ImageName : null));



            CreateMap<Brand, CreateResultDto>();
            CreateMap<Car, CreateResultDto>();
            CreateMap<Model, CreateResultDto>();
            CreateMap<Core.Entities.Type, CreateResultDto>();
            CreateMap<Country, CreateResultDto>();
            CreateMap<City,CreateResultDto>();
            CreateMap<Office, CreateResultDto>();
            CreateMap<AboutCity, CreateResultDto>();
        }
    }
}
