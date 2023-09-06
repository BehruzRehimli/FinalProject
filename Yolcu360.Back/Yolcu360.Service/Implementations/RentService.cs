using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Core.Repositories;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Rent;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.Service.Implementations
{
    public class RentService : IRentService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly IRentRepository _rentRepository;
        private readonly IOfficeRepository _officeRepository;
        private readonly UserManager<AppUser> _userManager;

        public RentService(ICarRepository carRepository, IRentRepository rentRepository, IMapper mapper, IOfficeRepository officeRepository, UserManager<AppUser> userManager)
        {
            _carRepository = carRepository;
            _rentRepository = rentRepository;
            _mapper = mapper;
            _officeRepository = officeRepository;
            _userManager = userManager;
        }

        public CreateResultDto Create(RentCreateDto dto)
        {
            if (!_carRepository.IsExsist(x=>x.Id==dto.CarId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "carId", ErrorMessages.NotFoundId(dto.CarId, "Car"));
            }
            if (dto.DropOfficeId!=null && !_officeRepository.IsExsist(x => x.Id == dto.DropOfficeId))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "DropOfficeId", ErrorMessages.NotFoundId(dto.DropOfficeId, "Office"));
            }
            Rent rent=_mapper.Map<Rent>(dto);
            rent.CreateDate=DateTime.Now;
            if (dto.Username!=null && dto.Username.Length>0)
            {
                AppUser user = _userManager.FindByNameAsync(dto.Username).Result;
                if (user != null)
                {
                    rent.User = user;
                }
            }
            _rentRepository.Add(rent);
            _rentRepository.Commit();
            return _mapper.Map<CreateResultDto>(rent);

        }
    }
}
