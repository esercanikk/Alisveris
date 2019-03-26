using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.User, Authorities.Delete, "Kullanıcıyı siler.")]
    public class DeleteUser : Command
    {
        public Guid Uid { get; set; }
    }
}
