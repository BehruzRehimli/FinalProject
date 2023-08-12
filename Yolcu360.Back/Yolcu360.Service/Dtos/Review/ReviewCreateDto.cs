using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Review
{
    public class ReviewCreateDto
    {
        public string Comment { get; set; }
        public int PersonelPoint { get; set; }
        public int SpeedPoint { get; set; }
        public int CleannesPoint { get; set; }
        public int CardId { get; set; }
    }
    public class ReviewCreateDtoValidator : AbstractValidator<ReviewCreateDto>
    {
        public ReviewCreateDtoValidator()
        {
            RuleFor(x => x.Comment).MaximumLength(500);
            RuleFor(x=>x.PersonelPoint).LessThanOrEqualTo(5).GreaterThan(0);
            RuleFor(x => x.SpeedPoint).LessThanOrEqualTo(5).GreaterThan(0);
            RuleFor(x=>x.CleannesPoint).LessThanOrEqualTo(5).GreaterThan(0);
            RuleFor(x => x.CardId).GreaterThan(0);
        }
    }
}
