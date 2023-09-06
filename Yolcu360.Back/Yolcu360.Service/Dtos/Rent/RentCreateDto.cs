using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Rent
{
    public class RentCreateDto
    {
        public int CarId { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Pasport { get; set; }
        public decimal CarPrice { get; set; }
        public decimal ExtPrice { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public int? DropOfficeId { get; set; }
        public string Username { get; set; }
    }
    public class RentCreateDtoValidator : AbstractValidator<RentCreateDto>
    {
        public RentCreateDtoValidator()
        {
            RuleFor(x => x.CarId).GreaterThan(0);
            RuleFor(x => x.Fullname).NotNull().MaximumLength(50);
            RuleFor(x => x.Phone).NotNull().MaximumLength(50);
            RuleFor(x => x.Email).NotNull().MaximumLength(100);
            RuleFor(x => x.Birthday).NotNull().MaximumLength(50);
            RuleFor(x => x.Pasport).NotNull().MaximumLength(50);
            RuleFor(x => x.Address).NotNull().MaximumLength(200);
            RuleFor(x=>x.Username).MaximumLength(50);

        }
    }
}
