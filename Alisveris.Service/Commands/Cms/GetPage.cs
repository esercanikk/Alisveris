using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Read, "Bir sayfa getirir.")]
    public class GetPage : Command
    {
        public string Id { get; set; }
    }
}
