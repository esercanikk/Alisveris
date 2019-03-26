using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Dilek silindi.")]
    public class DeleteWishlist : Command
    {
        public string Id { get; set; }

    }
}
