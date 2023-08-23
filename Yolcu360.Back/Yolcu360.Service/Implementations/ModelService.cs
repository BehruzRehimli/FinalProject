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
using Yolcu360.Service.Dtos.Model;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class ModelService : IModelService
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public ModelService(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }

        public CreateResultDto Create(ModelCreateDto dto)
        {
            if (_modelRepository.IsExsist(x => x.Name == dto.Name))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken(dto.Name));
            }
            Model model = _mapper.Map<Model>(dto);
            _modelRepository.Add(model);
            _modelRepository.Commit();
            return _mapper.Map<CreateResultDto>(model);
        }

        public void Delete(int id)
        {
            if (!_modelRepository.IsExsist(x => x.Id == id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "model"));
            }
            Model model = _modelRepository.Get(x => x.Id == id);
            _modelRepository.Delete(model);
            _modelRepository.Commit();
        }

        public void Edit(int id, ModelEditDto dto)
        {
            if (!_modelRepository.IsExsist(x => x.Id == id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "model"));
            }

            Model model =  _modelRepository.Get(x => x.Id == id);
            if (_modelRepository.IsExsist(x => x.Name == dto.Name && x.Id != model.Id))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Name", ErrorMessages.NameTaken(dto.Name));
            }
            model.Name = dto.Name;
            _modelRepository.Commit();
        }

        public ModelGetDto Get(int id)
        {
            if (!_modelRepository.IsExsist(x => x.Id == id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "brand"));
            }
            Model model = _modelRepository.Get(x => x.Id == id, "Cars");
            return _mapper.Map<ModelGetDto>(model);
        }

        public List<ModelGetAllDto> GetAll()
        {
            List<Model> models = _modelRepository.GetAll(x => true, "Cars").ToList();
            return _mapper.Map<List<ModelGetAllDto>>(models);
        }
    }
}
