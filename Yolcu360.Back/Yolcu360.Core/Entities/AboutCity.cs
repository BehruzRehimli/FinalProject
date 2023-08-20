using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Core.Entities
{
    public class AboutCity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ImageName { get; set; }
        public City City { get; set; }
    }
}
