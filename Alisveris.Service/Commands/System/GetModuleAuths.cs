using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.System, Authorities.Read, "Modül Yetkilerini Getirir")]
    public class GetModuleAuths : Command
    {
        public Guid? ModuleUid { get; set; }
        public Guid? RoleUid { get; set; }
    }
}
