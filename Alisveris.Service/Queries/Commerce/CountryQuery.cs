using Alisveris.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries.Commerce
{
    public class CountryQuery : Query
    {

        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
