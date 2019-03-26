using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Read, "Bir yazı getirir.")]
    public class GetPost : Command
    {
        public string Id { get; set; }
    }
}
    