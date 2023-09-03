using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;

namespace Yolcu360.Service.Interfaces
{
    public interface IBrandService
    {
        BrandGetDto Get(int id);
        CreateResultDto Create(BrandCreateDto dto);
        void Delete(int id);
        List<BrandGetAllDto> GetAll();
        void Edit(int id,BrandEditDto dto);
        object GetAdmin(int page);
    }
}
