using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Admin
{
    public class AdminCreateDto
    {
        public string Fullname { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AgainPassword { get; set; }
    }
    public class AdminCreateDtoValidator : AbstractValidator<AdminCreateDto>
    {
        public AdminCreateDtoValidator()
        {
            RuleFor(x=>x.Fullname).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x=>x.UserName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.PhoneNumber).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.Email).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(x => x.Password).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.AgainPassword).NotNull().NotEmpty().MaximumLength(50);
        }
    }
}
