using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Model
{
    public class ModelGetAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarsCount { get; set; }
        public ModelGetAllDtoBrand Brand { get; set; }
    }
    public class ModelGetAllDtoBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
