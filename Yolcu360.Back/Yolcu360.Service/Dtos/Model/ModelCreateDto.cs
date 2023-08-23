using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Model
{
    public class ModelCreateDto
    {
        public string Name{ get; set; }
        public int BrandId { get; set; }
    }
    public class ModelCreateDtoValidator:AbstractValidator<ModelCreateDto>
    {
        public ModelCreateDtoValidator()
        {
            RuleFor(x => x.BrandId).GreaterThan(0);
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
        }
    }
}
