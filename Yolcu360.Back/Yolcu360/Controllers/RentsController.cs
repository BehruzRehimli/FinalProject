using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Rent;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        private readonly IRentService _rentService;

        public RentsController(IRentService rentService)
        {
            _rentService = rentService;
        }

        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(RentCreateDto dto)
        {
            return _rentService.Create(dto);
        }
    }
}
