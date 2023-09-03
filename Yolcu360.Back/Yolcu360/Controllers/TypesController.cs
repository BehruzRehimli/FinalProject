using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Type;
using Yolcu360.Service.Implementations;
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
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("{id}")]
        public ActionResult<TypeGetDto> Get(int id)
        {
            return _typeService.Get(id);
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("")]
        public ActionResult<List<TypeGetAllDto>> Get()
        {
            return _typeService.GetAll();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(TypeCreateDto dto)
        {
            return _typeService.Create(dto);
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPut("{id}")]
        public ActionResult Edit(int id, TypeEditDto dto)
        {
            _typeService.Edit(id, dto);
            return NoContent();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _typeService.Delete(id);
            return NoContent();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("GetAdmin/{page}")]
        public ActionResult<object> GetAdmin(int page)
        {

            return _typeService.GetAdmin(page);
        }


    }
}
