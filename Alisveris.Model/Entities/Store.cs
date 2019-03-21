﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{
    public class Store:BaseEntity
    {
        public Store()
        {
            Products = new HashSet<Product>();
            StoreBrands = new HashSet<StoreBrand>();
            Coupons = new HashSet<Coupon>();
            ProductQuestions = new HashSet<ProductQuestion>();
        }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Owner { get; set; }
        public string Logo { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<StoreBrand> StoreBrands { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<ProductQuestion> ProductQuestions { get; set; }
    }
}
