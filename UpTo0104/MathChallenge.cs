using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    public class MathChallenge
    {
        public static int MathChallenges(int num1, int num2)
        {

            if (num1 == num2)
            {
                return -1;
            }

            return num1 > num2 ? 0 : 1;


        }
    }
}