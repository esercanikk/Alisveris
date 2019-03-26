using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Ürün kategorisi silindi.")]
    public class DeleteProductCategory : Command
    {
        public string Id { get; set; }

    }
}
