using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Core.Entities
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
        public int MailConfirmCode { get; set; }
        public string Pasport { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public List<Rent> Rents { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
