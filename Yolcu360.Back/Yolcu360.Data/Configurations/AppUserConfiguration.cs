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
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x=>x.Fullname).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.Pasport).HasMaxLength(50);
            builder.Property(x => x.Birthday).HasMaxLength(50);
        }
    }
}
