using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Country;

namespace Yolcu360.Service.Interfaces
{
    public interface ICountryService
    {
        CreateResultDto Create(CountryCreateDto dto);
        void Delete(int id);
        void Edit(int id, CountryEditDto dto);
        CountryGetDto Get(int id);
        List<CountryGetAllDto> GetAll();
    }
}
