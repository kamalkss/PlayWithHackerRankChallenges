using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    internal class flippingBits
    {
        public static long flippingBit(long n)
        {
            return ~(uint)n;
        }
    }
}
