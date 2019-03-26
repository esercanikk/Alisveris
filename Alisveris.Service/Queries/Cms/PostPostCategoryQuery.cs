using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries
{
    public class PostPostCategoryQuery:Query
    {
        public string Id { get; set; }
        public string PostId { get; set; }
        public string PostCategoryId { get; set; }


    }
}
