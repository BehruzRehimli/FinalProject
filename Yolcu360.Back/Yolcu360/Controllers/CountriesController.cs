using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
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
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("")]
        public ActionResult<List<CountryGetAllDto>> Get()
        {
            return _countryService.GetAll();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("{id}")]
        public ActionResult<CountryGetDto> Get(int id)
        {
            return _countryService.Get(id);
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(CountryCreateDto dto)
        {
            return _countryService.Create(dto);
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPut("{id}")]
        public ActionResult Edit(int id,CountryEditDto dto)
        {
            _countryService.Edit(id, dto);
            return NoContent();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _countryService.Delete(id);
            return NoContent();
        }
    }
}
