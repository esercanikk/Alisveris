﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Cms, Authorities.Delete, "Posta kategorisi silindi.")]
    public class DeletePostCategory : Command
    {
        public string Id { get; set; }

    }
}
