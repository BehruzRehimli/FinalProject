using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Dtos.City;

namespace Yolcu360.Service.Interfaces
{
    public interface ICityService
    {
        List<CityGetAllDto> Get();
        CityGetDto Get(int id);
        
    }
}
