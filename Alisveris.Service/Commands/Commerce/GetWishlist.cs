using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir dilek getirir.")]
    public class GetWishlist : Command
    {
        public string Id { get; set; }
    }
}
