using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Core.Entities
{
    public class Office: BaseEntity
    {
        public string Name { get; set; }
        public City City { get; set; }
    }
}
