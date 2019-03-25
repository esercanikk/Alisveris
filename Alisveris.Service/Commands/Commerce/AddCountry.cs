using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Create, "Yeni ülke oluşturur.")]
    public class AddCountry : Command
    {
        public string Name { get; set; }

    }
}
