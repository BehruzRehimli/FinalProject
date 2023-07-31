using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;

namespace Yolcu360.Data.Repositories
{
    public class TypeRepository : Repository<Yolcu360.Core.Entities.Type>, ITypeRepository
    {
        public TypeRepository(Yolcu360DbContext context) : base(context)
        {
        }
    }
}
