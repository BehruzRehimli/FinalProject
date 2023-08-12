using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Country
{
    public class CountryEditDto
    {
        public string Name { get; set; }

    }
    public class CountryEditDtoValidator : AbstractValidator<CountryEditDto>
    {
        public CountryEditDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
