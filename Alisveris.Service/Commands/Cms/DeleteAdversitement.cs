using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Delete, "Reklam silindi.")]
    public class DeleteAdvertisement : Command
    {
        public string Id { get; set; }

    }
}
