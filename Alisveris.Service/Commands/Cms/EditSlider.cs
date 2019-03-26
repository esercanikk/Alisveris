using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Update, "Kaydırıcı güncellendi.")]
    public class EditSlider : Command
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
}
