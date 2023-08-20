using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Service.Dtos.City;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;
        private readonly ICountryRepository _countryRepository;
        private string _rootPath;

        public CityService(ICityRepository cityService, IMapper mapper, ICountryRepository countryRepository)
        {
            _cityRepository = cityService;
            _mapper = mapper;
            _countryRepository = countryRepository;
            _rootPath=Directory.GetCurrentDirectory()+"/wwwroot";
        }

        public List<CityGetAllDto> Get()
        {
            List<City> cities=_cityRepository.GetAll(x => true, "Offices", "Country").ToList();
            return _mapper.Map<List<CityGetAllDto>>(cities);
        }

        public CityGetDto Get(int id)
        {
            City city=_cityRepository.Get(x => x.Id == id, "Offices", "Country");
            if (city == null)
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id,"City"));
            return _mapper.Map<CityGetDto>(city);
        }
        public CreateResultDto Create(CityCreateDto dto)
        {
            if (_cityRepository.IsExsist(x=>x.Name==dto.Name))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken("City"));
            }
            if (!_countryRepository.IsExsist(x=>x.Id==dto.CountryId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "CountryId", ErrorMessages.NotFoundId(dto.CountryId, "Country"));
            }
            City city = _mapper.Map<City>(dto);
            if (dto.ImageFile!=null)
            {
                city.ImageName = FileManager.UploadFile(_rootPath, "Uploads/City", dto.ImageFile);
            }
            _cityRepository.Add(city);
            _cityRepository.Commit();
            return _mapper.Map<CreateResultDto>(city);
        }
        public void Edit(int id, CityEditDto dto)
        {
            City city = _cityRepository.Get(x => x.Id == id, "Country");
            if (_cityRepository.IsExsist(x => x.Name == dto.Name && dto.Name!=city.Name))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken("City"));
            }
            if (!_countryRepository.IsExsist(x => x.Id == dto.CountryId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "CountryId", ErrorMessages.NotFoundId(dto.CountryId, "Country"));
            }
            city.HomeSliderOrder=dto.HomeSliderOrder;
            city.HomePopularOrder=dto.HomePopularOrder;
            city.Name = dto.Name;
            city.CountryId = dto.CountryId;
            string rvmImage = null;
            if (dto.ImageFile!=null)
            {
                rvmImage = city.ImageName;
                city.ImageName = FileManager.UploadFile(_rootPath, "Uploads/City", dto.ImageFile);
            }
            _cityRepository.Commit();
            if (rvmImage!=null)
            {
                FileManager.DeleteFile(_rootPath, "Uploads/City", rvmImage);
            }
        }

        public void Delete(int id)
        {
            City city = _cityRepository.Get(x => x.Id == id, "Offices");
            if (city==null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "City"));
            }
            if (city.Offices.Count>0)
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, ErrorMessages.NoDelete(city.Name, "Offices"));
            }
            string rmvImage = null;
            if (city.ImageName!=null)
            {
                rmvImage= city.ImageName;
            }
            _cityRepository.Delete(city);
            _cityRepository.Commit();
            if (rmvImage!=null) { FileManager.DeleteFile(_rootPath, "Uploads/City", rmvImage); }
        }

        public List<CityGetAllDto> GetSliderCity()
        {
            List<City> cities = _cityRepository.GetAll(x => x.HomeSliderOrder>0, "Offices", "Country").OrderBy(x=>x.HomeSliderOrder).ToList();
            return _mapper.Map<List<CityGetAllDto>>(cities);
        }
    }
}
