using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolcu360.Core.Entities;

namespace Yolcu360.Data.Configurations
{
    public class AboutCityConfiguration : IEntityTypeConfiguration<AboutCity>
    {
        public void Configure(EntityTypeBuilder<AboutCity> builder)
        {
            builder.Property(x=>x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Desc).IsRequired().HasMaxLength(1500);
            builder.HasOne(x => x.City).WithMany(x=>x.AboutCities).OnDelete(DeleteBehavior.Cascade);
            builder.Property(x=>x.ImageName).HasMaxLength(100);
        }
    }
}
