using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Model
{
    public class ModelEditDto
    {
        public string Name { get; set; }
        public int BrandId { get; set; }
    }
    public class ModelEditDtoValidator : AbstractValidator<ModelEditDto>
    {
        public ModelEditDtoValidator()
        {
            RuleFor(x => x.BrandId).GreaterThan(0);
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
        }
    }
}
