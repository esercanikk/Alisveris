using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Create, "Yeni şehir oluşturur.")]
    public class AddCity : Command
    {
        public string Name { get; set; }
        public string CountryId { get; set; }

    }
}
