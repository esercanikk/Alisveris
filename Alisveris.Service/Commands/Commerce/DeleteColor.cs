using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Renk siler.")]
    public class DeleteColor : Command
    {
        public string Id { get; set; }
    }
}
