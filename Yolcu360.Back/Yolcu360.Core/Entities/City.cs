using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Core.Entities
{
    public class City:BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string ImageName { get; set; }
        public List<Office> Offices { get; set; }
        public Country Country { get; set; }
    }
}
