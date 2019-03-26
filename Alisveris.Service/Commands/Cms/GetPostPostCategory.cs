using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Read, "Bir yazı ile yazı kategorisi arasındaki ilişkiyi getirir.")]
    public class GetPostPostCategory : Command
    {
        public string Id { get; set; }
    }
}
