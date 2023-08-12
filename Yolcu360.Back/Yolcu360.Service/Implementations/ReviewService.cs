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
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;
        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }
        public CreateResultDto Create(ReviewCreateDto dto)
        {
            Review review = _mapper.Map<Review>(dto);
            _reviewRepository.Add(review);
            _reviewRepository.Commit();
            return _mapper.Map<CreateResultDto>(review);
        }
    }
}
