using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Entities
{

    public class Slider : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Slide> Slides { get; set; }
    }
}
