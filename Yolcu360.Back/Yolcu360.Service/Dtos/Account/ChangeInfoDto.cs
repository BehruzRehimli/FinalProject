using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Account
{
    public class ChangeInfoDto
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Pasport { get; set; }
        public string Birthday { get; set; }

    }
    public class ChangeInfoDtoValidator:AbstractValidator<ChangeInfoDto>
    {
        public ChangeInfoDtoValidator()
        {
            RuleFor(x => x.Fullname).NotEmpty().MaximumLength(50);
            RuleFor(x=>x.Username).MaximumLength(50);
            RuleFor(x=>x.Phone).MaximumLength(50);
            RuleFor(x=>x.Email).MaximumLength(50);
            RuleFor(x => x.Address).MaximumLength(200);
            RuleFor(x => x.Birthday).MaximumLength(50);
            RuleFor(x => x.Pasport).MaximumLength(50);
        }
    }
}
