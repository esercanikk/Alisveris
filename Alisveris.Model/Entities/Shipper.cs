using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{
    public class Shipper:BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
