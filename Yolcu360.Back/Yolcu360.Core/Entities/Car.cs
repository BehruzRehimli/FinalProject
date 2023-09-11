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
        public int ModelId { get; set; }
        public int OfficeId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public decimal PriceDaily { get; set; }
        public decimal DepozitPrice { get; set; }
        public decimal TotalMillage { get; set; }
        public string ImageName { get; set; }
        public bool IsFreeCancelation { get; set; }
        public decimal? CancelationPrice { get; set; }
        public int MinDriverAge { get; set; }
        public int? MinYoungDriverAge { get; set; }
        public int MinDriverLisanseYear { get; set; }
        public int? MinYoungDriverLisanseYear { get; set; }
        public Transmission Transmission { get; set; }
        public FuelType FuelType { get; set; }
        public Model Model { get; set; }
        public Type Type { get; set; }
        public Office Office { get; set; }
        public List<Review> Reviews { get; set; }=new List<Review>();
        public List<Rent> Rents { get; set; }=new List<Rent>();
    }
}
