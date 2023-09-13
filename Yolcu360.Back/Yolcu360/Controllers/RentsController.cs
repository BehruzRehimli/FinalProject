using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yolcu360.Data;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Dtos.Rent;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        private readonly IRentService _rentService;
        private readonly Yolcu360DbContext _context;
        private readonly IMapper _mapper;

        public RentsController(IRentService rentService, Yolcu360DbContext context, IMapper mapper)
        {
            _rentService = rentService;
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("")]
        public ActionResult<CreateResultDto> Create(RentCreateDto dto)
        {
            return _rentService.Create(dto);
        }
        [HttpGet("GetForCharts")]
        public ActionResult GetForCharts()
        {
            var carJuly = _context.Rents.Where(rent => rent.CreateDate.Month == 7 && rent.Status==1).ToList().Sum(x => x.CarPrice);
            var exJuly = _context.Rents.Where(rent => rent.CreateDate.Month == 7 && rent.Status == 1).ToList().Sum(x => x.ExtPrice);
            var carAvq = _context.Rents.Where(rent => rent.CreateDate.Month == 8 && rent.Status == 1).ToList().Sum(x => x.CarPrice);
            var exAvq = _context.Rents.Where(rent => rent.CreateDate.Month == 8 && rent.Status == 1).ToList().Sum(x => x.ExtPrice);
            var carSen = _context.Rents.Where(rent => rent.CreateDate.Month == 9 && rent.Status == 1).ToList().Sum(x => x.CarPrice);
            var exSen = _context.Rents.Where(rent => rent.CreateDate.Month == 9 && rent.Status == 1).ToList().Sum(x => x.ExtPrice);
            var carOkt = _context.Rents.Where(rent => rent.CreateDate.Month == 10 && rent.Status == 1).ToList().Sum(x => x.CarPrice);
            var exOkt = _context.Rents.Where(rent => rent.CreateDate.Month == 10 && rent.Status == 1).ToList().Sum(x => x.ExtPrice);
            var carNov = _context.Rents.Where(rent => rent.CreateDate.Month == 11 && rent.Status == 1).ToList().Sum(x => x.CarPrice);
            var exNov = _context.Rents.Where(rent => rent.CreateDate.Month == 11 && rent.Status == 1).ToList().Sum(x => x.ExtPrice);
            var carDec = _context.Rents.Where(rent => rent.CreateDate.Month == 12 && rent.Status == 1).ToList().Sum(x => x.CarPrice);
            var exDec = _context.Rents.Where(rent => rent.CreateDate.Month == 12 && rent.Status == 1).ToList().Sum(x => x.ExtPrice);

            var totalCount = _context.Rents.Where(rent => rent.CreateDate.Month > 6 && rent.CreateDate.Month <= 12 && rent.Status==1).ToList();

            return Ok(new
            {
                JulyCar=carJuly,
                JulyExt=exJuly,
                AvqCar=carAvq,
                AvqExt=exAvq,
                SenCar = carSen,
                SenExt = exSen,
                OktCar = carOkt,
                OktExt = exOkt,
                NovCar = carNov,
                NovExt = exNov,
                DecCar = carDec,
                DecExt= exDec,
                Count=totalCount.Count(),
                Total=totalCount.Sum(x=>(x.CarPrice+x.ExtPrice)),
                TotalCar=totalCount.Sum(x=>x.CarPrice)
            });
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("")]
        public ActionResult<List<RentGetAllDto>> Get()
        {
            var rents = _context.Rents.Where(x => x.Status == 0).Include(x => x.Car).ToList();
            return _mapper.Map<List<RentGetAllDto>>(rents);
        }
        [HttpPut("{id}/{status}")]
        public ActionResult SetStatus(int id,int status)
        {
            var rent = _context.Rents.FirstOrDefault(x => x.Id == id);
            if (rent==null)
            {
                return NotFound();
            }
            rent.Status=status;
            _context.SaveChanges();
            return NoContent();
        }
        [HttpGet("PieChart")]
        public ActionResult PieChart()
        {
            var data=_context.Rents.Where(x=>x.Status==1).ToList().Count;
            var data2 = _context.Rents.Where(x => x.Status == 2).ToList().Count;
            var data3 = _context.Rents.Where(x => x.Status == 0).ToList().Count;

            return Ok(new
            {
                Accept=data,
                Rejected=data2,
                Pending=data3,

            });
        }

    }
}
