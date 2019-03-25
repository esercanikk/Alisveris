using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.System, Authorities.Delete, "Rol yetkisini siler")]
    public class RemoveRoleAuthority : Command
    {
        public Guid RoleUid { get; set; }
        public Guid ModuleAuthUid { get; set; }
    }
}
