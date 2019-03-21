using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{
   public class PostCategory:BaseEntity
    {
        public PostCategory()
        {
            Childs = new HashSet<PostCategory>();
        }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public bool HasSubCategory { get { return Childs.Count > 0; } }
        public string ParentId { get; set; }
        public PostCategory Parent { get; set; }
        public ICollection<PostCategory> Childs { get; set; }
        public ICollection<PostPostCategory> PostPostCategories { get; set; }
    }
}
