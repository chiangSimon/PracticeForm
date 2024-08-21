using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtest
{
    internal class IsPalindrome
    {
        public bool m_IsPalindrome(string x)
        {

            string opsite = "";
            for (int i = 0; i < x.Length; i++)
            {
                opsite = x[i] + opsite;
            }
            if (x == opsite) { return true; }
            return false;
        }
    }
}
