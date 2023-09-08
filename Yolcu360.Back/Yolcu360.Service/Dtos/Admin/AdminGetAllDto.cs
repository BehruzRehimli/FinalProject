using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Admin
{
    public  class AdminGetAllDto
    {
        public string Id { get; set; }
        public string Fullname { get; set; }
        public string  UserName { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Roles { get; set; }=new List<string>();

    }
}
