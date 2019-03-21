﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{
    public class District:BaseEntity
    {
        public string Name { get; set; }
        public string CityId { get; set; }
        public City City { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}