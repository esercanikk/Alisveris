using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir kupon getirir.")]
    public class GetCoupons : Command
    {
        public string Id { get; set; }
    }
}
