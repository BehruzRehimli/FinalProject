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
    public class RentConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder.Property(x=>x.Fullname).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Phone).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Birthday).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Pasport).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.CarPrice).IsRequired().HasColumnType("money");
            builder.Property(x => x.ExtPrice).IsRequired().HasColumnType("money");
            builder.HasOne(x=>x.Car).WithMany(x=>x.Rents).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.User).WithMany(x => x.Rents).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
