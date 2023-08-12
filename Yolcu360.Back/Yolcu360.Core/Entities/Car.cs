using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Data.Enums;

namespace Yolcu360.Core.Entities
{
    public class Car:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal PriceFor3Days { get; set; }
        public decimal DepozitPrice { get; set; }
        public decimal TotalMillage { get; set; }
        public string ImageName { get; set; }
        public bool IsFreeCancelation { get; set; }
        public decimal? CancelationPrice { get; set; }
        public int MinDriverAge { get; set; }
        public int MinYoungDriverAge { get; set; }
        public int MinDriverLisanseDay { get; set; }
        public Transmission Transmission { get; set; }
        public FuelType FuelType { get; set; }
        public Brand Brand { get; set; }
        public Type Type { get; set; }
        public Office Office { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
