using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Helpers;

namespace Yolcu360.Service.Dtos.City
{
    public class CityCreateDto
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public IFormFile ImageFile { get; set; }
    }
    public class CityCreateDtoValidator:AbstractValidator<CityCreateDto>
    {
        public CityCreateDtoValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().MaximumLength(50);
            RuleFor(x => x.CountryId).GreaterThan(0);
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
        }
    }
}
