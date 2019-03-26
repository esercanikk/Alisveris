using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Read, "Bir reklam getirir.")]
    public class GetAdvertisement : Command
    {
        public string Id { get; set; }
    }
}
