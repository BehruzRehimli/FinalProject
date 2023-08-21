using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Office;

namespace Yolcu360.Service.Interfaces
{
    public interface IOfficeService
    {
        void Edit(int id, OfficeEditDto dto);
        void Delete(int id);
        CreateResultDto Create(OfficeCreateDto dto);
        List<OfficeGetAllDto> GetAll();
        OfficeGetDto Get(int id);
        List<OfficeGetAllDto> GetForFooter();
        List<OfficeGetAllDto> GetHomePopular();
        List<OfficeSearchDto> Search(string input);

    }
}
