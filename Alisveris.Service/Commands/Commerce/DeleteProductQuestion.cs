﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Ürün sorusu silindi.")]
    public class DeleteProductQuestion : Command
    {
        public string Id { get; set; }

    }
}
