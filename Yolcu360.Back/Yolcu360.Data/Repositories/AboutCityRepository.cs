using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;

namespace Yolcu360.Data.Repositories
{
    public class AboutCityRepository : Repository<AboutCity>, IAboutCityRepository
    {
        public AboutCityRepository(Yolcu360DbContext context) : base(context)
        {
        }
    }
}
