using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Create, "Yeni kargo firması oluşturur.")]
    public class AddShipper : Command
    {
        public string Name { get; set; }
        public string Url { get; set; }

    }
}
