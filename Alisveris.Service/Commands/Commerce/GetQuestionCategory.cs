using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Read, "Bir soru kategorisi getirir.")]
    public class GetQuestionCategory : Command
    {
        public string Id { get; set; }
    }
}
