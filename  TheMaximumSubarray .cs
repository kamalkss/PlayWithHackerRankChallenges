using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges
{
    public class TheMaximumSubarray
    {
        public static int run(int[] a)
        {

            //calculate the sum of all possible subarrays
            int sum = 0;
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (sum > max)
                {
                    max = sum;
                }
                if (sum < 0)
                {
                    sum = 0;
                }
            }
            Array.Sort(a);
            if (max == 0) return a[^1];
            return max > a[^1] ? max : a[^1];

        }
    }
}