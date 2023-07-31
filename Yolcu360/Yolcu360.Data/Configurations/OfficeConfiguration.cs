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
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Address).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(20);
            builder.HasOne(x => x.City).WithMany(x => x.Offices).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
