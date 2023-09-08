using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Account
{
    public class ProfileDto
    {
        public string Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Pasport { get; set; }
        public string Email { get; set; }
        public List<ProfileDtoRent> Rents { get; set; }
    }
    public class ProfileDtoRent
    {
        public int Id { get; set; }
        public decimal CarPrice { get; set; }
        public decimal ExtPrice { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public DateTime CreateDate { get; set; }
        public ProfileDtoCar Car { get; set; }

    }
    public class ProfileDtoCar
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string Name { get; set; }

    }
}
