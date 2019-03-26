﻿using Alisveris.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries.Commerce
{
    public class CityQuery:Query
    {
        
        public string Name { get; set; }
        public string CountryId { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
