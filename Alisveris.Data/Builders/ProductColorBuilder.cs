using Alisveris.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Data.Builders
{
    public class ProductColorBuilder
    {
        public ProductColorBuilder(EntityTypeBuilder<ProductColor> builder)
        {
            builder.HasKey(b => b.Id);
            builder.HasOne(b => b.Product).WithMany(p => p.ProductColors).HasForeignKey(c => c.ProductId);
            builder.HasOne(b => b.Color).WithMany(c => c.ProductColors).HasForeignKey(p => p.ColorId);
            builder.HasQueryFilter(b => !b.IsDeleted);
        }
    }
}
