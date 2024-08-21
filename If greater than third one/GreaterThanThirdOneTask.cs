using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_greater_than_third_one
{

    public class GreaterThanThirdOneTask
    {
        public bool IfGreaterThanThirdOne(int[] arr)
        { return ((arr[0] + arr[1] > arr[2]) || (arr[0] * arr[1] > arr[2])); }
    }
}
