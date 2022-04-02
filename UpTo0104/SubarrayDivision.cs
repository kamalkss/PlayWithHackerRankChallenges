using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    internal class SubarrayDivision
    {
        public static int birthday(List<int> s, int d, int m)
        {
            var Result = 0;
            List<int[]> SubArrays = new List<int[]>();
            for (int i = 0; i < s.Count; i++)
            {
                if (i + m <= s.Count)
                {
                    SubArrays.Add(s.GetRange(i, m).ToArray());
                }
            }
            foreach (var item in SubArrays)
            {
                if (item.Sum() == d)
                {
                    Result++;
                }
            }

            return Result;
        }
    }
}
