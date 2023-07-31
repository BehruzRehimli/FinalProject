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
    public class TypeConfiguration : IEntityTypeConfiguration<Yolcu360.Core.Entities.Type>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Type> builder)
        {
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
