using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir renk getirir.")]
    public class GetColor : Command
    {
        public string Id { get; set; }
    }
}
