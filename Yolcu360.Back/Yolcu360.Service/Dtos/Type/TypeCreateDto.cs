using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Type
{
    public class TypeCreateDto
    {
        public string Name { get; set; }

    }
    public class TypeCreateDtoValidator : AbstractValidator<TypeCreateDto>
    {
        public TypeCreateDtoValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
