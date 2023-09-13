using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Rent
{
    public  class RentGetAllDto
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public decimal CarPrice { get; set; }
        public decimal ExtPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public RentGetAllDtoCar Car { get; set; }
    }
    public class RentGetAllDtoCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
    }
}
