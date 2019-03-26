using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir ürün getirir.")]
    public class GetProductCategory : Command
    {
        public string Id { get; set; }
    }
}
