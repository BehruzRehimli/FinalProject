using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Rent;

namespace Yolcu360.Service.Interfaces
{
    public interface IRentService
    {
        CreateResultDto Create(RentCreateDto dto);
    }
}
