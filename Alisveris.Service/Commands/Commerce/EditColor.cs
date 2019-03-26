using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Update, "Renk günceller.")]
    public class EditColor : Command
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

    }
}
