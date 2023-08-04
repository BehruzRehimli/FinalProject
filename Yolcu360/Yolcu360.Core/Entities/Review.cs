using System;
using System.Collections.Generic;
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
        public int MainPoint { get => (CleannesPoint + PersonelPoint + SpeedPoint) / 3; }
        public AppUser User { get; set; }
        public Car Car { get; set; }

    }
}
