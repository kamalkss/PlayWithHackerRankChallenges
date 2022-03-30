using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class kangaroos
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            for (int i = 1; i < 20; i++)
            {
                if (i * v1 + x1 == i * v2 + x2)
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }
}