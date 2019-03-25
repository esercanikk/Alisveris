using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Commands
{
    [Describe(CommandType.Commerce, Authorities.Create, "Yeni soru kategorisi oluşturur.")]
    public class AddQuestionCategory : Command
    {
        public string Name { get; set; }


    }
}
