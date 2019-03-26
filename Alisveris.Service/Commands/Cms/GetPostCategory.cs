using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Read, "Bir yazı kategorisini getirir.")]
    public class GetPostCategory : Command
    {
        public string Id { get; set; }
    }
}
