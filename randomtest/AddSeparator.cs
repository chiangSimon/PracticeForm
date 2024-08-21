using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtest
{
    internal class AddSeparator
    {
        public string m_AS (string x, string y)
        {
            string STR = "";
            string tmp = y;
            for (int i = 0; i < x.Length; i++)
            {
                STR = STR + (i < x.Length-1 ? x[i] + y : x[i].ToString());
            }
            return STR;
        }

    }
}
