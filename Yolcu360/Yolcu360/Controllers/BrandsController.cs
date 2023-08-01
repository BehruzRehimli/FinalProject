using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("{id}")]
        public ActionResult<BrandGetDto> Get(int id)
        {
            return _brandService.Get(id);
        }
        [HttpGet("")]
        public ActionResult<List<BrandGetAllDto>> Get()
        {
            return _brandService.GetAll();
        }
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(BrandCreateDto dto)
        {
            return _brandService.Create(dto);
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id,BrandEditDto dto)
        {
            _brandService.Edit(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _brandService.Delete(id);
            return NoContent();
        }
    }

}
