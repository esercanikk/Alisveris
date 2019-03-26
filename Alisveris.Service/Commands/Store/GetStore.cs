﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Store, Authorities.Read, "Bir mağaza getirir.")]
    public class GetStore : Command
    {
        public string Id { get; set; }
    }
}
