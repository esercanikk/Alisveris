using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Delete, "Dosya silindi.")]
    public class DeleteFile : Command
    {
        public string Id { get; set; }

    }
}
