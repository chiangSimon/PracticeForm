using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtest
{
    internal class ReturnEvenNumbers
    {
        public string REN (int n)
        {
            string STR = string.Empty;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    STR = STR + " " + i;
                }
            }
            return STR;
        }
    }
}
