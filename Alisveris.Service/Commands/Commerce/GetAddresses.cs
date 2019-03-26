using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Adresler getirir.")]
    public class GetAddresses : Command
    {
        public string Id { get; set; }
    }
}
