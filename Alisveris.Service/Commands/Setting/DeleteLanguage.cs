﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Setting, Authorities.Delete, "Dil silindi.")]
    public class DeleteLanguage : Command
    {
        public string Id { get; set; }

    }
}
