using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Type
{
    public class TypeEditDto
    {
        public string Name { get; set; }

    }
    public class TypeEditDtoValidator : AbstractValidator<TypeEditDto>
    {
        public TypeEditDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
