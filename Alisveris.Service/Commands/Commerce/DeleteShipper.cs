﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Kargo Firması silindi.")]
    public class DeleteShipper : Command
    {
        public string Id { get; set; }

    }
}
