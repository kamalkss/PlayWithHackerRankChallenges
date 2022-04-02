using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class findMedians
    {
        public static int findMedian(List<int> arr)
        {

            var count = arr.Count;
            var ordered = arr.OrderBy(x => x).ToList();
            var median = ordered.ElementAt(count / 2) + ordered.ElementAt((count - 1) / 2);
            median /= 2;
            return median;

        }
    }
}
