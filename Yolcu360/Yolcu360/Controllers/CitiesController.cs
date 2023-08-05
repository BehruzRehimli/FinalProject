using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.City;
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
    }
}
