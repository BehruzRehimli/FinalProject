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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.CancelationPrice).HasColumnType("money");
            builder.Property(x => x.PriceFor3Days).HasColumnType("money");
            builder.Property(x => x.CancelationPrice).HasColumnType("money");
            builder.Property(x => x.DepozitPrice).HasColumnType("money");
            builder.Property(x => x.Price).HasColumnType("money");
            builder.Property(x => x.ImageName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.TotalMillage).HasColumnType("decimal(18,2)");
            builder.HasOne(x=>x.Brand).WithMany(x=>x.Cars).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Type).WithMany(x => x.Cars).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Office).WithMany(x => x.Cars).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
