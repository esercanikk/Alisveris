using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{

    [Describe(CommandType.Commerce, Authorities.Delete, "Kupon silindi.")]
    public class DeleteCoupon : Command
    {
        public string Id { get; set; }

    }
}
