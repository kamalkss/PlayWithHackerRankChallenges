using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    internal class twoArrays
    {
        public static string twoArray(int k, List<int> A, List<int> B)
        {
            A.Sort();
            B.Sort();
            B.Reverse();
            return A.Where((t, i) => t + B[i] < k).Any() ? "NO" : "YES";
        }
    }
}
