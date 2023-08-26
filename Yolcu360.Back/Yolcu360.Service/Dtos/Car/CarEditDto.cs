using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Helpers;

namespace Yolcu360.Service.Dtos.Car
{
    public class CarEditDto
    {
        public string Name { get; set; }
        public decimal PriceDaily { get; set; }
        public decimal DepozitPrice { get; set; }
        public decimal TotalMillage { get; set; }
        public IFormFile ImageFile { get; set; }
        public bool IsFreeCancelation { get; set; }
        public decimal? CancelationPrice { get; set; }
        public int MinDriverAge { get; set; }
        public int? MinYoungDriverAge { get; set; }
        public int MinDriverLisanseYear { get; set; }
        public int? MinYoungDriverLisanseYear { get; set; }
        public int Transmission { get; set; }
        public int FuelType { get; set; }
        public int ModelId { get; set; }
        public int TypeId { get; set; }
        public int OfficeId { get; set; }

    }
    public class CarEditDtoValidator : AbstractValidator<CarEditDto>
    {
        public CarEditDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.PriceDaily).GreaterThan(0);
            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.ImageFile != null)
                {
                    if (x.ImageFile.ContentType != "image/png" && x.ImageFile.ContentType != "image/jpeg")
                    {
                        context.AddFailure("ImageFile", ErrorMessages.ImageFileType());
                    }
                    if (x.ImageFile.Length > 5 * 1024 * 1024)
                    {
                        context.AddFailure("ImageFile", ErrorMessages.ImageFileSize());
                    }
                }
            });
            RuleFor(x => x.MinDriverAge).GreaterThan(15);
            RuleFor(x => x.MinYoungDriverAge).GreaterThan(15);
            RuleFor(x => x.Transmission).GreaterThan(0).LessThanOrEqualTo(2);
            RuleFor(x => x.FuelType).GreaterThan(0).LessThanOrEqualTo(4);
            RuleFor(x => x.ModelId).GreaterThan(0);
            RuleFor(x => x.OfficeId).GreaterThan(0);
            RuleFor(x => x.TypeId).GreaterThan(0);

        }
    }
}
