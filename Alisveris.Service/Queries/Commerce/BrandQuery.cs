using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries.Commerce
{
    public class BrandQuery : Query
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Image { get; set; }
        public bool ShowInHome { get; set; }
        public bool IsActive { get; set; }
    }
}
