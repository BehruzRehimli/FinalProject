using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Office
{
    public class OfficeGetAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string OpenTimes { get; set; }
        public int CarsCount { get; set; }
        public OfficeGetAllCity City { get; set; }

    }
    public class OfficeGetAllCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public OfficeGetAllCountry Country { get; set; }
    }
    public class OfficeGetAllCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
