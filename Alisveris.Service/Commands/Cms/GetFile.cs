using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir dosya getirir.")]
    public class GetFile : Command
    {
        public string Id { get; set; }
    }
}
