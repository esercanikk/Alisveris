using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{
    public class OrderItem : BaseEntity
    {
            public OrderItem()
            {
                //Quantity = 1;
            }

            public string OrderId { get; set; }
            public Order Order { get; set; }
            public string ProductId { get; set; }
            public Product Product { get; set; }
            public int Quantity { get; set; }
            public decimal Total { get { return Product.NewPrice * Quantity; } }
            public string Name { get; set; }
            public string ShortDescription { get; set; }
            public decimal NewPrice { get; set; }
            public decimal OldPrice { get; set; }
            public int AvailabilityCount { get; set; }
            public string CategoryId { get; set; }
            public ProductCategory Category { get; set; }
            public string BrandId { get; set; }
            public Brand Brand { get; set; }
            public string StoreId { get; set; }
            public Store Store { get; set; }
            public string ShipperId { get; set; }
            public Shipper Shipper { get; set; }
    }
}
