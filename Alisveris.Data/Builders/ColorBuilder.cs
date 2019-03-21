using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Alisveris.Model.Entities;


namespace Alisveris.Data.Builders
{
    public class ColorBuilder
    {
        public ColorBuilder(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.Property(b => b.Value).IsRequired().HasMaxLength(200);
           
            builder.HasQueryFilter(b => !b.IsDeleted);
        }

    }
}

