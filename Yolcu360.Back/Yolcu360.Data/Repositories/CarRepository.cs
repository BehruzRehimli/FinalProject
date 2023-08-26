﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;

namespace Yolcu360.Data.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(Yolcu360DbContext context) : base(context)
        {
        }
    }
}
