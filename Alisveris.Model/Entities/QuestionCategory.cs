using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{
    public class QuestionCategory:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<ProductQuestion> ProductQuestions { get; set; }
    }
}
