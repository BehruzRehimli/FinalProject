using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Service.Dtos.Car;
using Yolcu360.Service.Dtos.City;
using Yolcu360.Service.Dtos.Common;

namespace Yolcu360.Service.Interfaces
{
    public interface ICarService
    {
        List<CarGetAllDto> Get();
        CreateResultDto Create(CarCreateDto dto);
        CarGetDto Get(int id);
        void Edit(int id, CarEditDto dto);
        void Delete(int id);
        List<CarGetAllDto> CarsList(int id);
        object GetAdmin(int page);

    }
}
