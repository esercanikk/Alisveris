using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries
{
    public class FileQuery
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string OriginalName { get; set; }
        public string Alt { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Extension { get; set; }

    }
}
