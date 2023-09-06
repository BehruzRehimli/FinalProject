using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Account
{
    public class ChangePasswordDto
    {
        public string Current { get; set; }
        public string NewPassword { get; set; }
        public string AgainPassword { get; set; }

    }
    public class ChangePasswordDtoValidator:AbstractValidator<ChangePasswordDto>
    {
        public ChangePasswordDtoValidator()
        {
            RuleFor(x => x.Current).NotEmpty().MaximumLength(50);
            RuleFor(x => x.NewPassword).NotEmpty().MaximumLength(50);
            RuleFor(x => x.AgainPassword).NotEmpty().MaximumLength(50);
        }
    }
}
