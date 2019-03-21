using Alisveris.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Data.Builders
{

    public class ReviewBuilder
    {
        public ReviewBuilder(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.Property(b => b.Email).IsRequired().HasMaxLength(200);
            builder.HasOne(b => b.Product).WithMany(c => c.Reviews).HasForeignKey(p => p.ProductId);

            builder.HasQueryFilter(b => !b.IsDeleted);
        }

    }
}
