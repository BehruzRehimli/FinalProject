using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Core.Entities
{
    public class Model:BaseEntity
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public List<Car> Cars { get; set; }
    }
}
