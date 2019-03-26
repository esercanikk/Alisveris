using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Görüş silindi.")]
    public class DeleteReview : Command
    {
        public string Id { get; set; }

    }
}
