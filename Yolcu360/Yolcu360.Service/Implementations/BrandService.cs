using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{

    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }
        public CreateResultDto Create(BrandCreateDto dto)
        {
            if (_brandRepository.IsExsist(x=>x.Name==dto.Name))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest,"Name",ErrorMessages.NameTaken(dto.Name));
            }
            Brand brand=_mapper.Map<Brand>(dto);
            _brandRepository.Add(brand);
            _brandRepository.Commit();
            return _mapper.Map<CreateResultDto>(brand);
        }

        public void Delete(int id)
        {
            if (!_brandRepository.IsExsist(x=>x.Id==id))
            {
                throw new  RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "brand"));
            }
            Brand brand = _brandRepository.Get(x => x.Id == id);
            _brandRepository.Delete(brand);
            _brandRepository.Commit();
        }

        public void Edit(int id, BrandEditDto dto)
        {
            if (!_brandRepository.IsExsist(x => x.Id == id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "brand"));
            }

            Brand brand = _brandRepository.Get(x => x.Id == id);
            if (_brandRepository.IsExsist(x => x.Name == dto.Name &&x.Id!=brand.Id))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken(dto.Name));
            }
            brand.Name= dto.Name;
            _brandRepository.Commit();
        }

        public BrandGetDto Get(int id)
        {
            if (!_brandRepository.IsExsist(x => x.Id == id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "brand"));
            }
            Brand brand = _brandRepository.Get(x => x.Id == id,"Cars");
            return _mapper.Map<BrandGetDto>(brand);
        }

        public List<BrandGetAllDto> GetAll()
        {
            List<Brand> brands=_brandRepository.GetAll(x=>true,"Cars").ToList();
            return _mapper.Map<List<BrandGetAllDto>>(brands);
        }
    }
}
