using Alisveris.Model.Entities;
using Alisveris.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries
{
    public class ProductColorQuery :Query
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Alt { get; set; }
        public string ProductId { get; set; }
        public string ColorId { get; set; }

    }
}
