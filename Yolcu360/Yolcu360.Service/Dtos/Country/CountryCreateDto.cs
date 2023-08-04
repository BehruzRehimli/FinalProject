using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Country
{
    public class CountryCreateDto
    {
        public string Name { get; set; }

    }
    public class CountryCreateDtoValidator : AbstractValidator<CountryCreateDto>
    {
        public CountryCreateDtoValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
