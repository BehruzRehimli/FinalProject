using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.City;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Implementations;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("")]
        public ActionResult<List<CityGetAllDto>> Get()
        {
            return _cityService.Get();
        }
        [HttpGet("{id}")]
        public ActionResult<CityGetDto> Get(int id)
        {
            return _cityService.Get(id);
        }
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create([FromForm]CityCreateDto dto)
        {
            return _cityService.Create(dto);
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id,[FromForm]CityEditDto dto)
        {
            _cityService.Edit(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _cityService.Delete(id);
            return NoContent();
        }
        [HttpGet("homeSlider")]
        public ActionResult<List<CityGetAllDto>> GetSliderCity()
        {
            return _cityService.GetSliderCity();
        }

    }
}
