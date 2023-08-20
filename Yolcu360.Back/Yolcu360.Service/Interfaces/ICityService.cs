using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Dtos.City;
using Yolcu360.Service.Dtos.Common;

namespace Yolcu360.Service.Interfaces
{
    public interface ICityService
    {
        List<CityGetAllDto> Get();
        CityGetDto Get(int id);
        CreateResultDto Create(CityCreateDto dto);
        void Edit(int id, CityEditDto dto);
        void Delete(int id);
        List<CityGetAllDto> GetSliderCity();
    }
}
