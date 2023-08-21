using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.AboutCity
{
    public class GetAboutCityDto
    {
        public string Title { get; set; }   
        public int Desc { get; set; }
        public int Order { get; set; }
        public int ImageName { get; set; }
        public GetAboutCityDtoCity City { get; set; }

    }
    public class GetAboutCityDtoCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
