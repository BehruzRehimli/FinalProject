﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Core.Entities
{
    public class Type:BaseEntity
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }
}
