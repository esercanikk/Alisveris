using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir ürün sorusu getirir.")]
    public class GetProductQuestion : Command
    {
        public string Id { get; set; }
    }
}
