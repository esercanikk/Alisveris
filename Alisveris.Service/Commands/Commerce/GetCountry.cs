using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir ülke getirir.")]
    public class GetCountry : Command
    {
        public string Id { get; set; }
    }
}
