﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir görüş getirir.")]
    public class GetReview : Command
    {
        public string Id { get; set; }
    }
}
