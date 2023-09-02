using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Dtos.Car
{
    public class CarGetDto
    {
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
        public CarGetDtoModel Model { get; set; }
        public CarGetDtoType Type { get; set; }
        public CarGetDtoOffice Office { get; set; }
        public List<CarGetDtoReview> Reviews { get; set; }


    }
    public class CarGetDtoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CarGetDtoBrand Brand { get; set; }
        public int CarsCount { get; set; }
    }
    public class CarGetDtoBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarsCount { get; set; }
    }
    public class CarGetDtoType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarsCount { get; set; }
    }
    public class CarGetDtoOffice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string OpenTimes { get; set; }
        public int CarsCount { get; set; }
        public CarGetDtoCity City { get; set; }
    }
    public class CarGetDtoCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CarGetDtoCountry Country { get; set; }
    }
    public class CarGetDtoCountry
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CarGetDtoReview
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int CleannesPoint { get; set; }
        public int PersonelPoint { get; set; }
        public int SpeedPoint { get; set; }
        public int MainPoint { get; set; }
        public CarGetDtoUser User { get; set; }
    }
    public class CarGetDtoUser
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
    }
}
