using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Helpers;

namespace Yolcu360.Service.Dtos.AboutCity
{
    public class CreateAboutCityDto
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public IFormFile ImageFile { get; set; }
        public int CityId { get; set; }
    }
    public class CreateAboutCityDtoValidator : AbstractValidator<CreateAboutCityDto>
    {
        public CreateAboutCityDtoValidator()
        {
            RuleFor(x=>x.Title).MaximumLength(100);
            RuleFor(x=>x.Desc).NotEmpty().MaximumLength(1500);
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
            RuleFor(x=>x.CityId).GreaterThan(0);
            RuleFor(x=>x.Order).GreaterThan(0);
        }
    }
}
