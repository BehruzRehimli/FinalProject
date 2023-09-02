using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
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
        [Authorize(Roles = "Admin,SuperAdmin")]
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
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(OfficeCreateDto dto)
        {
            return _officeService.Create(dto);
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPut("{id}")]
        public ActionResult Edit(int id,OfficeEditDto dto)
        {
            _officeService.Edit(id, dto);
            return NoContent();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
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
        [HttpGet("Search/{input}")]
        public ActionResult<List<OfficeSearchDto>> Search(string input)
        {
            return _officeService.Search(input);
        }
    }
}
