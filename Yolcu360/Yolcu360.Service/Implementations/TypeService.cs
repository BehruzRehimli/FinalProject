using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Data.Repositories;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Type;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class TypeService : ITypeService
    {
        private readonly ITypeRepository _typeRepository;
        private readonly IMapper _mapper;

        public TypeService(ITypeRepository typeRepository, IMapper mapper)
        {
            _typeRepository = typeRepository;
            _mapper = mapper;
        }

        public CreateResultDto Create(TypeCreateDto dto)
        {
            if (_typeRepository.IsExsist(x => x.Name == dto.Name))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken(dto.Name));
            }
            Yolcu360.Core.Entities.Type type = _mapper.Map<Yolcu360.Core.Entities.Type>(dto);
            _typeRepository.Add(type);
            _typeRepository.Commit();
            return _mapper.Map<CreateResultDto>(type);
        }

        public void Delete(int id)
        {
            if (!_typeRepository.IsExsist(x => x.Id == id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "type"));
            }
            Yolcu360.Core.Entities.Type type = _typeRepository.Get(x => x.Id == id);
            _typeRepository.Delete(type);
            _typeRepository.Commit();
        }

        public void Edit(int id, TypeEditDto dto)
        {
            if (!_typeRepository.IsExsist(x => x.Id == id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "type"));
            }

            Core.Entities.Type type = _typeRepository.Get(x => x.Id == id);
            if ( _typeRepository.IsExsist(x => x.Name == dto.Name && x.Id!=type.Id))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken(dto.Name));
            }
            type.Name = dto.Name;
            _typeRepository.Commit();
        }

        public TypeGetDto Get(int id)
        {
            if (!_typeRepository.IsExsist(x => x.Id == id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "type"));
            }
            Core.Entities.Type type =   _typeRepository.Get(x => x.Id == id, "Cars");
            return _mapper.Map<TypeGetDto>(type);
        }

        public List<TypeGetAllDto> GetAll()
        {
            List<Core.Entities.Type> types = _typeRepository.GetAll(x => true, "Cars").ToList();
            return _mapper.Map<List<TypeGetAllDto>>(types);
        }
    }

}
