using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class extraLongFactorials
    {
        public static void extraLongFactorial(int n)
        {
            var fac = BigInteger.One;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
            Console.WriteLine(fac);
        }
    }
}
