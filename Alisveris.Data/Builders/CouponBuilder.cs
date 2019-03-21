﻿using Alisveris.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Data.Builders
{
    public class CouponBuilder
    {
        public CouponBuilder(EntityTypeBuilder<Coupon> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);
            builder.HasOne(b => b.Order).WithMany(c => c.Coupons).HasForeignKey(p => p.OrderId);
            builder.HasOne(b => b.ForStore).WithMany(c => c.Coupons).HasForeignKey(p => p.ForStoreId);



            builder.HasQueryFilter(b => !b.IsDeleted);
        }
    }
}
