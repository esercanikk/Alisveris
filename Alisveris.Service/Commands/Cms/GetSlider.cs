using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Read, "Bir kaydırıcı getirir.")]
    public class GetSlider : Command
    {
        public string Id { get; set; }
    }
}
