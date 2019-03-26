﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir kargo firması getirir.")]
    public class GetShipper : Command
    {
        public string Id { get; set; }
    }
}
