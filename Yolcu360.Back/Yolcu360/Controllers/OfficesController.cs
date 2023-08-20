using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Core.Repositories;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Office;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        private readonly IOfficeService _officeService;

        public OfficesController(IOfficeService officeService)
        {
            _officeService = officeService;
        }

        [HttpGet("")]
        public ActionResult<List<OfficeGetAllDto>> Get()
        {
            return _officeService.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<OfficeGetDto> Get(int id)
        {
            return _officeService.Get(id);
        }
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(OfficeCreateDto dto)
        {
            return _officeService.Create(dto);
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id,OfficeEditDto dto)
        {
            _officeService.Edit(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _officeService.Delete(id);
            return NoContent();
        }
        [HttpGet("footer")]
        public ActionResult<List<OfficeGetAllDto>> GetForFooter()
        {
            return _officeService.GetForFooter();
        }
        [HttpGet("HomePopular")]
        public ActionResult<List<OfficeGetAllDto>> GetHomePopular()
        {
            return _officeService.GetHomePopular();
        }
    }
}
