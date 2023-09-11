using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Data.Enums;
using Yolcu360.Service.Dtos.Car;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Model;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IOfficeRepository _officeRepository;
        private readonly ITypeRepository _typeRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;
        private string _rootPath;

        public CarService(ICarRepository carRepository, IMapper mapper, IOfficeRepository officeRepository, ITypeRepository typeRepository, IModelRepository modelRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _rootPath = Directory.GetCurrentDirectory() + "/wwwroot";
            _officeRepository = officeRepository;
            _typeRepository = typeRepository;
            _modelRepository = modelRepository;
        }

        public CreateResultDto Create(CarCreateDto dto)
        {
            if (!_modelRepository.IsExsist(x=>x.Id==dto.ModelId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "ModelId", ErrorMessages.NotFoundId(dto.ModelId, "Model"));
            }
            if (!_typeRepository.IsExsist(x => x.Id == dto.TypeId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "TypeId", ErrorMessages.NotFoundId(dto.TypeId, "Type"));
            }
            if (!_officeRepository.IsExsist(x => x.Id == dto.OfficeId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "OfficeId", ErrorMessages.NotFoundId(dto.ModelId, "Office"));
            }
            Car car = _mapper.Map<Car>(dto);
            car.ImageName = FileManager.UploadFile(_rootPath, "Uploads/Car", dto.ImageFile);
            _carRepository.Add(car);
            _carRepository.Commit();
            return _mapper.Map<CreateResultDto>(car);
        }

        public List<CarGetAllDto> Get()
        {
            List<Car> cars=_carRepository.GetAll(x=>true).Include(x=>x.Type).Include(x=>x.Model).ThenInclude(x=>x.Brand).Include(x=>x.Office)
                .ThenInclude(x=>x.City).ThenInclude(x=>x.Country).Include(x=>x.Reviews.OrderByDescending(x=>x.CreateDate)).ThenInclude(x=>x.User).ToList();
            return _mapper.Map<List<CarGetAllDto>>(cars);
        }

        public CarGetDto Get(int id)
        {
            if (!_carRepository.IsExsist(x=>x.Id==id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "Car"));
            }
            Car car = _carRepository.GetAll(x => x.Id == id).Include(x => x.Type).Include(x => x.Model).ThenInclude(x => x.Brand).Include(x => x.Office)
                .ThenInclude(x => x.City).ThenInclude(x => x.Country).Include(x => x.Reviews.OrderByDescending(x=>x.CreateDate)).ThenInclude(x => x.User).First();

            return _mapper.Map<CarGetDto>(car);
        }
        public void Edit(int id, CarEditDto dto)
        {
            if (!_modelRepository.IsExsist(x => x.Id == dto.ModelId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "ModelId", ErrorMessages.NotFoundId(dto.ModelId, "Model"));
            }
            if (!_typeRepository.IsExsist(x => x.Id == dto.TypeId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "TypeId", ErrorMessages.NotFoundId(dto.TypeId, "Type"));
            }
            if (!_officeRepository.IsExsist(x => x.Id == dto.OfficeId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "OfficeId", ErrorMessages.NotFoundId(dto.ModelId, "Office"));
            }
            Car car = _carRepository.Get(x=>x.Id==id);
            if (car == null)
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "Car"));
            }
            car.Name=dto.Name;
            car.PriceDaily=dto.PriceDaily;
            car.TotalMillage=dto.TotalMillage;
            car.MinDriverAge=dto.MinDriverAge;
            car.MinDriverLisanseYear=dto.MinDriverLisanseYear;
            car.MinYoungDriverAge=dto.MinYoungDriverAge;
            car.MinYoungDriverLisanseYear = dto.MinYoungDriverLisanseYear;
            car.OfficeId = dto.OfficeId;
            car.TypeId= dto.TypeId;
            car.ModelId= dto.ModelId;
            car.DepozitPrice=dto.DepozitPrice;
            car.IsFreeCancelation=dto.IsFreeCancelation;
            car.CancelationPrice=dto.CancelationPrice;
            car.Transmission = (Transmission)dto.Transmission;
            car.FuelType=(FuelType)dto.FuelType;

            string rmvimg = null;
            if (dto.ImageFile!=null)
            {
                rmvimg = car.ImageName;
                car.ImageName = FileManager.UploadFile(_rootPath, "Uploads/Car", dto.ImageFile);

            }
            _carRepository.Commit();
            if (rmvimg!=null)
            {
                FileManager.DeleteFile(_rootPath, "Uploads/Car", rmvimg);
            }

        }

        public void Delete(int id)
        {
            if (!_carRepository.IsExsist(x => x.Id == id))
            {
                throw new RestException(System.Net.HttpStatusCode.NotFound, ErrorMessages.NotFoundId(id, "Car"));
            }
            Car car = _carRepository.GetAll(x => x.Id == id).Include(x => x.Type).Include(x => x.Model).ThenInclude(x => x.Brand).Include(x => x.Office)
                .ThenInclude(x => x.City).ThenInclude(x => x.Country).Include(x => x.Reviews).ThenInclude(x => x.User).First();

            FileManager.DeleteFile(_rootPath, "Uploads/Car", car.ImageName);
            _carRepository.Delete(car);
            _carRepository.Commit();
        }

        public List<CarGetAllDto> CarsList(int id,CarListDto dto)
        {
            var cars = _carRepository.GetAll(x => x.OfficeId == id)
                 .Include(x => x.Type)
                 .Include(x => x.Model).ThenInclude(x => x.Brand)
                 .Include(x => x.Office).ThenInclude(x => x.City).ThenInclude(x => x.Country)
                 .Include(x => x.Reviews).ThenInclude(x => x.User).
                 Include(x=>x.Rents)
                 .ToList(); // cars listesini veritabanından çekiyoruz

            // Şimdi araçları filtreleyebiliriz
            List<Car> availableCars = cars.Where(car =>
            {
                // Arabanın kiralama dönemlerini kontrol ediyoruz
                bool isAvailable = true;
                foreach (var rent in car.Rents)
                {
                    if ((dto.PickDate >= rent.PickUpDate && dto.PickDate <= rent.DropOffDate) || (dto.DropDate>=rent.PickUpDate && dto.DropDate <=rent.DropOffDate) || (rent.PickUpDate>=dto.PickDate && rent.PickUpDate<=dto.DropDate))
                    {
                        // Araba bu kiralama döneminde başka bir kiracıya verilmiş, uygun değil.
                        isAvailable = false;
                        break; // Kiralama dönemleri arasında çakışma bulduysak döngüyü kırabiliriz.
                    }
                }

                // Araba uygunsa, true döndürüyoruz.
                return isAvailable;
            }).ToList();

            // Sonuçları DTO'ya dönüştürün
            return _mapper.Map<List<CarGetAllDto>>(availableCars);
        }

        public object GetAdmin(int page)
        {
            var cars = _carRepository.GetAll(x => true);
            var maxPage = Math.Ceiling((decimal)cars.ToList().Count / 10);
            var datas = cars.Skip((page - 1) * 10).Take(10).Include(x => x.Type).Include(x => x.Model).ThenInclude(x => x.Brand).Include(x => x.Office)
                .ThenInclude(x => x.City).ThenInclude(x => x.Country).Include(x => x.Reviews).ThenInclude(x => x.User).ToList();
            return new { data = _mapper.Map<List<CarGetAllDto>>(datas), pageCount = maxPage };

        }
    }
}
