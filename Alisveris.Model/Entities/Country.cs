using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{
    public class Country:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
