using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Brand
{
    public class BrandGetAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarsCount { get; set; }
    }
}
