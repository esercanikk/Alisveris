using Alisveris.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Data.Builders
{
    public class PageBuilder
    {
        public PageBuilder(EntityTypeBuilder<Page> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(200);
            builder.Property(b => b.Slug).IsRequired().HasMaxLength(200);
            builder.Property(b => b.Photo).IsRequired().HasMaxLength(200);
            builder.Property(b => b.MetaTitle).HasMaxLength(200);

            builder.HasQueryFilter(b => !b.IsDeleted);
        }

    }
}
