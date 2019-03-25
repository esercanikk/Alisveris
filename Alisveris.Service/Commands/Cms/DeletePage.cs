using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Delete, "Sayfa silindi.")]
    public class DeletePage : Command
    {
        public string Id { get; set; }

    }
}
