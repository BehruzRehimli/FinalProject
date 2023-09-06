using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Core.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Comment { get; set; }
        public int CleannesPoint { get; set; }
        public int PersonelPoint { get; set; }
        public int SpeedPoint { get; set; }
        [NotMapped]
        public decimal MainPoint { get => ((decimal)CleannesPoint + (decimal)PersonelPoint + (decimal)SpeedPoint) / 3; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public AppUser User { get; set; }
        public Car Car { get; set; }

    }
}
