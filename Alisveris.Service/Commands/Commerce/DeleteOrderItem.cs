using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Sipariş öğesi silindi.")]
    public class DeleteOrderItem : Command
    {
        public string Id { get; set; }

    }
}
