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
        public List<Office> Offices { get; set; }
    }
}
