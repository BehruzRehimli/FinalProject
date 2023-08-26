using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.Car;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("")]
        public ActionResult<List<CarGetAllDto>> Get()
        {
            return _carService.Get();
        }
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create([FromForm]CarCreateDto dto)
        {
            return _carService.Create(dto);
        }
        [HttpGet("{id}")]
        public ActionResult<CarGetDto> Get(int id)
        {
            return _carService.Get(id);
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id,[FromForm]CarEditDto dto)
        {
            _carService.Edit(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _carService.Delete(id);
            return NoContent();
        }
    }
}
