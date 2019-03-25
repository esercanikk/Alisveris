using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.User, Authorities.Read, "Çıkış yapar.")]
    public class Logout : Command
    {
    }
}
