using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Country;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public CreateResultDto Create(CountryCreateDto dto)
        {
            if (_countryRepository.IsExsist(x=>x.Name==dto.Name))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken(dto.Name));
            }
            Country country = _mapper.Map<Country>(dto);
            _countryRepository.Add(country);
            _countryRepository.Commit();
            return _mapper.Map<CreateResultDto>(country);
        }

        public void Delete(int id)
        {
            Country country = _countryRepository.Get(x=>x.Id==id,"Cities");
            if (country==null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "Country"));
            }
            if (country.Cities.Count>0)
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, ErrorMessages.NoDelete("Country", "Cities"));
            }
            _countryRepository.Delete(country);
            _countryRepository.Commit();
        }

        public void Edit(int id, CountryEditDto dto)
        {
            Country country = _countryRepository.Get(x => x.Id == id);
            if (country == null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "Country"));
            }
            if (country.Name!=dto.Name && _countryRepository.IsExsist(x => x.Name == dto.Name))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken(dto.Name));
            }
            country.Name= dto.Name;
            _countryRepository.Commit();
        }

        public CountryGetDto Get(int id)
        {
            Country country = _countryRepository.Get(x => x.Id == id);
            if (country == null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "Country"));
            }
            return _mapper.Map<CountryGetDto>(country);
        }

        public List<CountryGetAllDto> GetAll()
        {
            var countries=_countryRepository.GetAll(x=>true).ToList();
            return _mapper.Map<List<CountryGetAllDto>>(countries);
        }
    }
}
