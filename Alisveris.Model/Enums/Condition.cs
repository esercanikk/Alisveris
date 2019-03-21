using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Model.Enums
{
    [Flags]
    public enum Condition
    {
        NotSpecified = 1,
        New = 2,
        Used = 4
    }
}
