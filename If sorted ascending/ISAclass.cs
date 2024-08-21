using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_sorted_ascending
{
    public class ISAclass
    {
        public bool IfSortedAsceeding(int[] arr)
        {
            return (arr[0] < arr[1] && arr[1] < arr[2]);
        }
    }

}
