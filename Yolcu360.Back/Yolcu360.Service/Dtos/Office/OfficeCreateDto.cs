using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Office
{
    public class OfficeCreateDto
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string OpenTimes { get; set; }

    }
    public class OfficeCreateDtoValidator : AbstractValidator<OfficeCreateDto>
    {
        public OfficeCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
            RuleFor(x => x.CityId).GreaterThan(0);
            RuleFor(x => x.Address).NotEmpty().MaximumLength(250);
            RuleFor(x => x.Phone).NotEmpty().MaximumLength(20);
            RuleFor(x => x.OpenTimes).NotEmpty().MaximumLength(20);
        }
    }
}
