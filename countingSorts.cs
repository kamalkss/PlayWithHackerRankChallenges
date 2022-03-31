using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class countingSorts
    {
        public static List<int> countingSort(List<int> arr)
        {
            var count = new int[100];
            for (int i = 0; i < arr.Count; i++)
            {
                count[arr[i]]++;
            }

            //remove the extra zeros

            return new List<int>();
        }
    }
}
