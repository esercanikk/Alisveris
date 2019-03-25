using Alisveris.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries
{
    public class DistrictQuery
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CityId { get; set; }
        public City City { get; set; }


    }
}
