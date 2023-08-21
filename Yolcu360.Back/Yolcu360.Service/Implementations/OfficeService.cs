using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Office;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class OfficeService : IOfficeService
    {
        private readonly IOfficeRepository _officeRepository;
        private readonly IMapper _mapper;

        public OfficeService(IOfficeRepository officeRepository, IMapper mapper)
        {
            _officeRepository = officeRepository;
            _mapper = mapper;
        }

        public CreateResultDto Create(OfficeCreateDto dto)
        {
            if (_officeRepository.IsExsist(x => x.Name == dto.Name))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken(dto.Name));
            }
            Office office=_mapper.Map<Office>(dto);
            _officeRepository.Add(office);
            _officeRepository.Commit();
            return _mapper.Map<CreateResultDto>(office);
        }

        public void Delete(int id)
        {
            Office offices = _officeRepository.GetAll(x => x.Id == id).Include(x => x.City).ThenInclude(x => x.Country).First();
            if (offices == null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "Office"));
            }
            _officeRepository.Delete(offices);
            _officeRepository.Commit();
        }

        public void Edit(int id, OfficeEditDto dto)
        {
            Office offices = _officeRepository.GetAll(x => x.Id == id).Include(x => x.City).ThenInclude(x => x.Country).First();
            if (offices == null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "Office"));
            }
            if (_officeRepository.IsExsist(x=>x.Name==dto.Name && x.Id!=id))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest,"Name",ErrorMessages.NameTaken(dto.Name));
            }
            offices.Name = dto.Name;
            offices.Address = dto.Address;
            offices.Phone= dto.Phone;
            offices.OpenTimes= dto.OpenTimes;
            offices.CityId= dto.CityId;
            _officeRepository.Commit();
        }

        public OfficeGetDto Get(int id)
        {
            Office offices = _officeRepository.GetAll(x => x.Id==id).Include(x => x.City).ThenInclude(x => x.Country).Include(x => x.Cars).Include(x=>x.City).ThenInclude(x=>x.AboutCities).First();
            if (offices==null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "Office"));
            }
            return _mapper.Map<OfficeGetDto>(offices);
        }

        public List<OfficeGetAllDto> GetAll()
        {
            List<Office> offices = _officeRepository.GetAll(x => true).Include(x=>x.City).ThenInclude(x=>x.Country).Include(x=>x.Cars).ToList();
            return _mapper.Map<List<OfficeGetAllDto>>(offices);
        }

        public List<OfficeGetAllDto> GetForFooter()
        {
            List<Office> offices = _officeRepository.GetAll(x => x.Id>3 && x.Id<20).Include(x => x.City).ThenInclude(x => x.Country).Include(x => x.Cars).ToList();
            return _mapper.Map<List<OfficeGetAllDto>>(offices);
        }

        public List<OfficeGetAllDto> GetHomePopular()
        {
            List<Office> offices = _officeRepository.GetAll(x =>x.City.HomePopularOrder>0).Include(x => x.City).ThenInclude(x => x.Country).Include(x => x.Cars).OrderBy(x=>x.City.HomePopularOrder).ToList();
            return _mapper.Map<List<OfficeGetAllDto>>(offices);
        }

        public List<OfficeSearchDto> Search(string input)
        {
            var offices = _officeRepository.GetAll(x => x.Name.Contains(input)).ToList();
            return _mapper.Map<List<OfficeSearchDto>>(offices);
        }
    }
}
