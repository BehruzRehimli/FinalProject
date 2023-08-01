using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Type;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerBase
    {
        private readonly ITypeService _typeService;

        public TypesController(ITypeService typeService)
        {
            _typeService = typeService;
        }
        [HttpGet("{id}")]
        public ActionResult<TypeGetDto> Get(int id)
        {
            return _typeService.Get(id);
        }
        [HttpGet("")]
        public ActionResult<List<TypeGetAllDto>> Get()
        {
            return _typeService.GetAll();
        }
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(TypeCreateDto dto)
        {
            return _typeService.Create(dto);
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id, TypeEditDto dto)
        {
            _typeService.Edit(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _typeService.Delete(id);
            return NoContent();
        }

    }
}
