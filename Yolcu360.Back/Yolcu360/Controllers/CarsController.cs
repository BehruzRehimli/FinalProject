using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Yolcu360.Core.Entities;
using Yolcu360.Data;
using Yolcu360.Service.Dtos.Car;
using Yolcu360.Service.Dtos.Common;
using Yolcu360.Service.Implementations;
using Yolcu360.Service.Interfaces;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly Yolcu360DbContext _context;

        public CarsController(ICarService carService, Yolcu360DbContext context)
        {
            _carService = carService;
            _context = context;
        }
        [HttpGet("")]
        public ActionResult<List<CarGetAllDto>> Get()
        {
            return _carService.Get();
        }
        [HttpPost("")]
        public ActionResult<CreateResultDto> Create([FromForm]CarCreateDto dto)
        {
            return _carService.Create(dto);
        }
        [HttpGet("{id}")]
        public ActionResult<CarGetDto> Get(int id)
        {
            return _carService.Get(id);
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id,[FromForm]CarEditDto dto)
        {
            _carService.Edit(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _carService.Delete(id);
            return NoContent();
        }
        [HttpPost("CarsList/{id}")]
        public ActionResult<List<CarGetAllDto>> CarsList(int id,[FromForm] CarListDto dto)
        {
            return _carService.CarsList(id,dto);
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpGet("GetAdmin/{page}")]
        public ActionResult<object> GetAdmin(int page)
        {

            return _carService.GetAdmin(page);
        }




        [HttpGet("ExportExcel")]
        public async Task<FileResult> ExportPeopleInExcel()
        {
            var people =  _context.Cars.Include(x=>x.Type).Include(x=>x.Office).Include(x=>x.Model).AsEnumerable();
            var fileName = "cars.xlsx";
            return GenerateExcel(fileName, people);
        }
        private FileResult GenerateExcel(string fileName, IEnumerable<Car> cars)
        {
            DataTable dataTable = new DataTable("Cars");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id"),
                new DataColumn("Name"),
                new DataColumn("PriceDaily"),
                new DataColumn("DepozitPrice"),
                new DataColumn("TotalMillage"),
                new DataColumn("Model Name"),
                new DataColumn("Office Name"),
                new DataColumn("Type Name"),

            });

            foreach (var car in cars)
            {
                dataTable.Rows.Add(car.Id, car.Name,car.PriceDaily,car.DepozitPrice,car.TotalMillage,car.Model.Name,car.Office.Name,car.Type.Name);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dataTable);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);

                    return File(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        fileName);
                }
            }

        }

    }
}
