using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.City
{
    public class CityGetDto
    {
        public string Name { get; set; }
        public int HomeSliderOrder { get; set; }
        public string ImageName { get; set; }
        public int OfficesCount { get; set; }
        public int HomePopularOrder { get; set; }
        public CityGetCountry Country { get; set; }
    }
    public class CityGetCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
