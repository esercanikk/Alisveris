using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "İlçe siler.")]
    public class DeleteDistrict: Command
    {
        public string Id { get; set; }
    }
}
