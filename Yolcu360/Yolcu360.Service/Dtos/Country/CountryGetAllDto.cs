using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Country
{
    public class CountryGetAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CitiesCount { get; set; }

    }
}
