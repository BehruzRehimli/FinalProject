using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;
using Yolcu360.Data.Configurations;

namespace Yolcu360.Data
{
    public class Yolcu360DbContext:DbContext
    {
        public Yolcu360DbContext(DbContextOptions<Yolcu360DbContext> opt ):base(opt) { }

        public DbSet<Brand> Brands { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BrandConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
