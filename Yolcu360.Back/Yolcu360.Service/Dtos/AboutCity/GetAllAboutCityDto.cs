using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.AboutCity
{
    public class GetAllAboutCityDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ImageName { get; set; }
        public int Order { get; set; }
        public GetAllAboutCityDtoCity City { get; set; }
    }
    public class GetAllAboutCityDtoCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
