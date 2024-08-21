using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtest
{
    internal class CheckBracketsSequence
    {
        public bool m_CBS (string STR) 
        {
            int num = 0;
            for (int i = 0; i < STR.Length; i++) 
            {
                if (STR[i] == '(')
                {
                    num++;
                }
                else if (STR[i] == ')')
                {
                    num--;
                }
            }
            return num == 0;
        }
     
    }
}
