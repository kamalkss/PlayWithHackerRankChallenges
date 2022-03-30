using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public static class aVVeryBigSum
    {
        public static long aVeryBigSums(List<long> ar)
        {
            long sum = new long();
            foreach (var item in ar)
            {
                sum += item;
            }

            return sum;
        }
    }
}
