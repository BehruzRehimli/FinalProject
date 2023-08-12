using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Account
{
    public class MailConfirmDto
    {
        public int  ConfirmCode { get; set; }
    }
    public class MailConfirmDtoValidator : AbstractValidator<MailConfirmDto>
    {
        public MailConfirmDtoValidator()
        {
            RuleFor(x=>x.ConfirmCode).GreaterThan(0).LessThanOrEqualTo(9999);
        }
    }
}
