using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Review;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(ReviewCreateDto dto)
        {
            return _reviewService.Create(dto);
        }
    }
}
