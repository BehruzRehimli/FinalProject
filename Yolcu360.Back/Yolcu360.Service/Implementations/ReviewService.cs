using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Review;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public ReviewService(IReviewRepository reviewRepository, IMapper mapper, ICarRepository carRepository)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
            _carRepository = carRepository;
        }
        public CreateResultDto Create(ReviewCreateDto dto, AppUser user)
        {
            if (!_carRepository.IsExsist(x=>x.Id==dto.CarId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "CarId", ErrorMessages.NotFoundId(dto.CarId, "car"));
            }
            Review review = _mapper.Map<Review>(dto);
            review.CreateDate=DateTime.UtcNow;
            review.User= user;
            _reviewRepository.Add(review);
            _reviewRepository.Commit();
            return _mapper.Map<CreateResultDto>(review);
        }
    }
}
