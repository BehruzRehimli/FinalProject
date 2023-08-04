using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Service.Dtos.City;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository cityService, IMapper mapper)
        {
            _cityRepository = cityService;
            _mapper = mapper;
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
    }
}
