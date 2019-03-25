﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Marka silindi.")]
    public class DeleteBrand : Command
    {
        public string Id { get; set; }

    }
}
