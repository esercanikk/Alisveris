using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Delete, "Soru kategorisi silindi.")]
    public class DeleteQuestionCategory : Command
    {
        public string Id { get; set; }

    }
}
