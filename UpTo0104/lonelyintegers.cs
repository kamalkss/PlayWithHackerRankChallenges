using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    internal class lonelyintegers
    {
        public static int lonelyinteger(List<int> a)
        {
            //find the unique integer in list a
            int result = 0;
            for (int i = 0; i < a.Count; i++)
            {
                result ^= a[i];
            }
            return result;

        }
    }
}
