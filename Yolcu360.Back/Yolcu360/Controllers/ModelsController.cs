using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Model;
using Yolcu360.Service.Implementations;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IModelService _modelService;

        public ModelsController(IModelService modelService)
        {
            _modelService = modelService;
        }
        [HttpGet("{id}")]
        public ActionResult<ModelGetDto> Get(int id)
        {
            return _modelService.Get(id);
        }
        [HttpGet("")]
        public ActionResult<List<ModelGetAllDto>> Get()
        {
            return _modelService.GetAll();
        }
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(ModelCreateDto dto)
        {
            return _modelService.Create(dto);
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id, ModelEditDto dto)
        {
            _modelService.Edit(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _modelService.Delete(id);
            return NoContent();
        }

    }
}
