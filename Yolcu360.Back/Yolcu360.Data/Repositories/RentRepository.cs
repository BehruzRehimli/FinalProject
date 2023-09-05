﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;

namespace Yolcu360.Data.Repositories
{
    public class RentRepository :  Repository<Rent>,IRentRepository
    {
        public RentRepository(Yolcu360DbContext context) : base(context)
        {
        }
    }
}
