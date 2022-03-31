using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class TheLongestIncreasingSubsequence
    {
        static public int Run(int[] sequence)
        {
            //
            // Write your code below; return type and arguments should be according to the problem\'s requirements
            //
            int k = 0;
            int[] dp = new int[sequence.Length];
            for (int i = 0; i < sequence.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
                k = Math.Max(k, dp[i]);
            }

            return k;
        }
    }
}
