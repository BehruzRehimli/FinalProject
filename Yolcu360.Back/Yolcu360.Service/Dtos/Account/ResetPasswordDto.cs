using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Account
{
    public class ResetPasswordDto
    {
        public string NewPassword { get; set; }
        public string AgainPassword { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }

    }
    public class ResetPasswordDtoValidator:AbstractValidator<ResetPasswordDto>
    {
        public ResetPasswordDtoValidator()
        {
            RuleFor(x => x.NewPassword).NotEmpty().MaximumLength(50);
            RuleFor(x => x.AgainPassword).NotEmpty().MaximumLength(50);
            RuleFor(x => x.UserId).NotEmpty().MaximumLength(150);
            RuleFor(x => x.Token).NotEmpty().MaximumLength(500);
        }
    }
}
