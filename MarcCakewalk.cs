using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges
{
    public class MarcCakewalk
    {
        public static long marcCakewalk(List<int> calorie)
        {
            // for each J cupcake marc have to to run j^2  * c miles
            // find minumum sort for minimum calories
            // (2^0 * x = x) + (2^1 * x = 2x) + (2^2 * x = 4x)
            calorie.Sort();
            calorie.Reverse();
            long minimumSum = 0;
            //minimumSum += (long)Math.Pow(2, calorie.IndexOf(Cookie)) * Cookie;

            for (int i = 0; i < calorie.Count; i++)
            {
                minimumSum += (long)Math.Pow(2, i) * calorie[i];
            }
            return minimumSum;
        }
    }
}