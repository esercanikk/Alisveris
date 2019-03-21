using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{
    public class Order : BaseEntity
    {
        public Order(){
            this.OrderItems = new HashSet<OrderItem>();
        }

        public string UserName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DemandDate { get; set; }
        public string OrderCode { get; set; }
        public int Quantity { get; set; }
        public Address DeliveryAddress { get; set; }
        public Address InvoiceAddress { get; set; }
        public string DeliveryAddressId { get; set; }
        public string InvoiceAddressId { get; set; }
        public string StoreId { get; set; }
        public Store Store { get; set; }
        public decimal Total { get { return OrderItems.Sum(s => s.Total); } }
        public OrderStatus OrderStatus { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
    }
}
