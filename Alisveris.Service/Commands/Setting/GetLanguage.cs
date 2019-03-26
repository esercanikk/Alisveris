﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Setting, Authorities.Read, "Bir dil getirir.")]
    public class GetLanguage : Command
    {
        public string Id { get; set; }
    }
}
