using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.User, Authorities.Read, "Token aktif mi.")]
    public class Verify : Command
    {
    }
}
