using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.AboutCity;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutCitiesController : ControllerBase
    {
        private readonly IAboutCityService _aboutCityService;

        public AboutCitiesController(IAboutCityService aboutCityService)
        {
            _aboutCityService = aboutCityService;
        }

        [HttpPost("")]
        public ActionResult<CreateResultDto> Create( [FromForm]CreateAboutCityDto dto)
        {
            return _aboutCityService.Create(dto);
        }
        [HttpGet("{id}")]
        public ActionResult<GetAboutCityDto> Get(int id)
        {
            return _aboutCityService.Get(id);
        }
        [HttpGet("")]
        public ActionResult<List<GetAllAboutCityDto>> Get()
        {
            return _aboutCityService.GetAll();
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id,[FromForm]EditAboutCityDto dto)
        {
            _aboutCityService.Edit(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _aboutCityService.Delete(id);
            return NoContent();
        }
    }
}
