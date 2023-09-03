using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Implementations;
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
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("{id}")]
        public ActionResult<BrandGetDto> Get(int id)
        {
            return _brandService.Get(id);
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("")]
        public ActionResult<List<BrandGetAllDto>> Get()
        {
            return _brandService.GetAll();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(BrandCreateDto dto)
        {
            return _brandService.Create(dto);
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPut("{id}")]
        public ActionResult Edit(int id,BrandEditDto dto)
        {
            _brandService.Edit(id, dto);
            return NoContent();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _brandService.Delete(id);
            return NoContent();
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("GetAdmin/{page}")]
        public ActionResult<object> GetAdmin(int page)
        {

            return _brandService.GetAdmin(page);
        }
    }

}
