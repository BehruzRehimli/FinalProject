using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Service.Dtos.AboutCity;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class AboutCityService : IAboutCityService
    {
        private readonly IAboutCityRepository _aboutCityRepository;
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;
        private string _rootPath;

        public AboutCityService(IAboutCityRepository aboutCityRepository, IMapper mapper, ICityRepository cityRepository)
        {
            _aboutCityRepository = aboutCityRepository;
            _mapper = mapper;
            _cityRepository = cityRepository;
            _rootPath = Directory.GetCurrentDirectory() + "/wwwroot";
        }

        public CreateResultDto Create(CreateAboutCityDto dto)
        {
            if (!_cityRepository.IsExsist(x=>x.Id==dto.CityId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "CityId", ErrorMessages.NotFoundId(dto.CityId, "City"));
            }
            var about = _mapper.Map<AboutCity>(dto);
            if (dto.ImageFile!=null)
            {
                about.ImageName = FileManager.UploadFile(_rootPath, "Uploads/AboutCity", dto.ImageFile);
            }
            _aboutCityRepository.Add(about);
            _aboutCityRepository.Commit();
            return _mapper.Map<CreateResultDto>(about);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, EditAboutCityDto dto)
        {
            throw new NotImplementedException();
        }

        public GetAboutCityDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<GetAllAboutCityDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
