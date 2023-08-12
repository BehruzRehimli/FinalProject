using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Country;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpGet("")]
        public ActionResult<List<CountryGetAllDto>> Get()
        {
            return _countryService.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<CountryGetDto> Get(int id)
        {
            return _countryService.Get(id);
        }
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(CountryCreateDto dto)
        {
            return _countryService.Create(dto);
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id,CountryEditDto dto)
        {
            _countryService.Edit(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _countryService.Delete(id);
            return NoContent();
        }
    }
}
