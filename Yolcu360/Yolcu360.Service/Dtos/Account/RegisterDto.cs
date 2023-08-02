using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Account
{
    public class RegisterDto
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(x=>x.Email).NotEmpty().MaximumLength(100).MinimumLength(5).EmailAddress();
            RuleFor(x => x.Fullname).NotEmpty().MaximumLength(50).MinimumLength(3);
            RuleFor(x => x.Username).NotEmpty().MaximumLength(50).MinimumLength(3);
            RuleFor(x=>x.Password).NotEmpty().MinimumLength(8).MaximumLength(50);
            RuleFor(x => x.ConfirmPassword).NotEmpty().MinimumLength(8).MaximumLength(50);

            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.Password != x.ConfirmPassword)
                {
                    context.AddFailure("ConfirmPassword", "Confirm Password must be same Password!");
                }
            });

        }
    }
}
