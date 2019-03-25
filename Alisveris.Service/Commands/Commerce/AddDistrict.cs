using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Create, "Yeni ilçe oluşturur.")]
    public class AddDistrict : Command
    {
        public string Name { get; set; }
        public string CityId { get; set; }
    }
}
