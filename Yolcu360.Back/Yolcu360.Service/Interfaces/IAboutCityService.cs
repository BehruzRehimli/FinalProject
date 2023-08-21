using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Dtos.AboutCity;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;

namespace Yolcu360.Service.Interfaces
{
    public interface IAboutCityService
    {
        GetAboutCityDto Get(int id);
        CreateResultDto Create(CreateAboutCityDto dto);
        void Delete(int id);
        List<GetAllAboutCityDto> GetAll();
        void Edit(int id, EditAboutCityDto dto);
    }
}
