using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Ürün resmi silindi.")]
    public class DeleteProductPhoto : Command
    {
        public string Id { get; set; }

    }
}
