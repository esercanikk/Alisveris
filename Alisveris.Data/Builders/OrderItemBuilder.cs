using Alisveris.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Data.Builders
{
    public class OrderItemBuilder
    {
        public OrderItemBuilder(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(o => o.Id);
            builder.HasOne(o => o.Product).WithMany(o => o.OrderItems).HasForeignKey(o => o.ProductId);
            builder.HasOne(o => o.Shipper).WithMany(o => o.OrderItems).HasForeignKey(o => o.ShipperId);
            builder.HasQueryFilter(b => !b.IsDeleted);
        }
    }
}
