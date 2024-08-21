using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_NegativeorZero
{
    public class PNZclass
    {
        public string PNZ(double NUM)
        {
            if (NUM > 0) { return "positive"; }
            if (NUM < 0) { return "negative"; }
            if (NUM == 0) { return "zero"; }
            else { return "XX"; }
        }

    }
}
