using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Data.Enums;
using Yolcu360.Service.Dtos.AboutCity;

namespace Yolcu360.Service.Dtos.Car
{
    public class CarGetAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PriceDaily { get; set; }
        public decimal DepozitPrice { get; set; }
        public decimal TotalMillage { get; set; }
        public string ImageName { get; set; }
        public bool IsFreeCancelation { get; set; }
        public decimal? CancelationPrice { get; set; }
        public int MinDriverAge { get; set; }
        public int MinYoungDriverAge { get; set; }
        public int MinDriverLisanseYear { get; set; }
        public int MinYoungDriverLisanseYear { get; set; }
        public int Transmission { get; set; }
        public int FuelType { get; set; }
        public CarGetAllDtoModel Model { get; set; }
        public CarGetAllDtoType Type { get; set; }
        public CarGetAllDtoOffice Office { get; set; }
        public List<CarGetAllDtoReview> Reviews { get; set; }

    }
    public class CarGetAllDtoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CarGetAllDtoBrand Brand { get; set; }
        public int CarsCount { get; set; }
    }
    public class CarGetAllDtoBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarsCount { get; set; }
    }
    public class CarGetAllDtoType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarsCount { get; set; }
    }
    public class CarGetAllDtoOffice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string OpenTimes { get; set; }
        public int CarsCount { get; set; }
        public CarGetAllDtoCity City { get; set; }
    }
    public class CarGetAllDtoCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CarGetAllDtoCountry Country { get; set; }
    }
    public class CarGetAllDtoCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CarGetAllDtoReview
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int CleannesPoint { get; set; }
        public int PersonelPoint { get; set; }
        public int SpeedPoint { get; set; }
        public decimal MainPoint { get; set; }
        public DateTime CreateDate { get; set; }
        public CarGetAllDtoUser User { get; set; }
    }
    public class CarGetAllDtoUser
    {
        public string Fullname { get; set; }
    }
}
