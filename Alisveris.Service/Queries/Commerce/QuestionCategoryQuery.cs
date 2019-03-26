using Alisveris.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Service.Queries.Commerce
{
    public class QuestionCategoryQuery
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductQuestion> ProductQuestions { get; set; }
    }
}
