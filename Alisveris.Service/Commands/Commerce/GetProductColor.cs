﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir ürün rengi getirir.")]
    public class GetProductColor : Command
    {
        public string Id { get; set; }
    }
}
