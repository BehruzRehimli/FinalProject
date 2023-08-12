using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Office
{
    public class OfficeGetDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string OpenTimes { get; set; }
        public int CarsCount { get; set; }
        public OfficeGetCity City { get; set; }
    }
    public class OfficeGetCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public OfficeGetCountry Country { get; set; }
    }
    public class OfficeGetCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
