using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Type;

namespace Yolcu360.Service.Interfaces
{
    public interface ITypeService
    {
        CreateResultDto Create(TypeCreateDto dto);
        void Delete(int id);
        void Edit(int id, TypeEditDto dto);
        TypeGetDto Get(int id);
        List<TypeGetAllDto> GetAll();
        object GetAdmin(int page);

    }
}
