using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir marka getirir.")]
    public class GetBrand : Command
    {
        public string Id { get; set; }
    }
}
