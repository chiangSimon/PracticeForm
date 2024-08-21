using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomtest
{
    internal class Two7snext_toeachother
    {
        public int Two7snext(int[] arr )
        {
            int num = 0;
            for ( int i = 0; i < arr.Length -1 ; i++ ) 
            {
                if (arr[i] == 7 && arr[i+1] == 7) 
                {
                    num = num +1;
                }
            }
            return num;
        } 
    }
}
