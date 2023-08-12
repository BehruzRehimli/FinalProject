using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Account
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(x=>x.Username).NotEmpty().MaximumLength(50).MinimumLength(3);
            RuleFor(x => x.Password).NotEmpty().MaximumLength(50).MinimumLength(8);
        }
    }
}
