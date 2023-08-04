using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    public class Yolcu360DbContext:IdentityDbContext
    {
        public Yolcu360DbContext(DbContextOptions<Yolcu360DbContext> opt ):base(opt) { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Yolcu360.Core.Entities.Type> Types { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BrandConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
