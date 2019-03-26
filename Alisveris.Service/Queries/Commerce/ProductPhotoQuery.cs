using Alisveris.Model.Entities;
using Alisveris.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries
{
    public class ProductPhotoQuery
    {
        public string Id { get; set; }
        public string Medium { get; set; }
        public string Small { get; set; }
        public string Large { get; set; }
        public string Alt { get; set; }
        public string ProductId { get; set; }
    }
}
