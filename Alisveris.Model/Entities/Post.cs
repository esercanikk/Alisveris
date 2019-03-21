using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{
   public class Post:BaseEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public ICollection<PostPostCategory> PostPostCategories { get; set; }
    }
}
