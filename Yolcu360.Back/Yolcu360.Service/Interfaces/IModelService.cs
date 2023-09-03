using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Dtos.Brand;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Model;

namespace Yolcu360.Service.Interfaces
{
    public  interface IModelService
    {
        ModelGetDto Get(int id);
        CreateResultDto Create(ModelCreateDto dto);
        void Delete(int id);
        List<ModelGetAllDto> GetAll();
        void Edit(int id, ModelEditDto dto);
        object GetAdmin(int page);

    }
}
