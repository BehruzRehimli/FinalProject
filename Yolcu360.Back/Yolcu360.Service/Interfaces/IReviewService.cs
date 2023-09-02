using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Review;

namespace Yolcu360.Service.Interfaces
{
    public interface IReviewService
    {
        CreateResultDto Create(ReviewCreateDto dto,AppUser user);
    }
}
