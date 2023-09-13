using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Core.Entities
{
    public class Rent:BaseEntity
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
        public DateTime CreateDate { get; set; }
        public Car Car { get; set; }
        public AppUser User { get; set; }
        public int Status { get; set; }
    }
}
