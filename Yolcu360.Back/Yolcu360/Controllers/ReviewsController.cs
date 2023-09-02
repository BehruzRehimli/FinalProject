using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Yolcu360.Core.Entities;
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
        private readonly UserManager<AppUser> _userManager;
        public ReviewsController(IReviewService reviewService, UserManager<AppUser> userManager)
        {
            _reviewService = reviewService;
            _userManager = userManager;
        }

        [Authorize(Roles = "Member,Admin,SuperAdmin")]
        [HttpPost("")]
        public async Task<ActionResult<CreateResultDto>> Create(ReviewCreateDto dto)
        {
            AppUser user =await _userManager.FindByNameAsync(User?.Identity?.Name);
            return _reviewService.Create(dto,user);
        }
    }
}
