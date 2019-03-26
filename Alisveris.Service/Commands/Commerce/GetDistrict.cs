using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir ilçe getirir.")]
    public class GetDistrict : Command
    {
        public string Id { get; set; }
    }
}
