﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries.Commerce
{
    public class ProductCategoryQuery : Query
    {
       
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string ParentId { get; set; }
        public bool HasSubCategory { get; set; }

    }
}
