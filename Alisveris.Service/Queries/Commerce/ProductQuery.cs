﻿using Alisveris.Model.Entities;
using Alisveris.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries
{
    public class ProductQuery:Query
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string CategoryName { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsNew { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Cost { get; set; }
        public float Tax { get; set; }
        public int RatingsCount { get; set; }
        public float RatingsValue { get; set; }
        public int AvailabilityCount { get; set; }
        public float? Weight { get; set; }
        public string AdditionalInformation { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string CategoryId { get; set; }
        public string BrandId { get; set; }
        public string StoreId { get; set; }
        public Alisveris.Model.Entities.Store Store { get; set; }
        public IList<ProductPhoto> Images { get; set; }
        public Condition Condition { get; set; }
    }
}
