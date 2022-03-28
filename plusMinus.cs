using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges
{
    public class plusMinus
    {
        public static void plusMinuss(List<int> arr)
        {
            int positive = 0;
            int negative = 0;
            int zero = 0;

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    positive++;
                }
                else if (item < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine((double)positive / arr.Count);
            Console.WriteLine((double)negative / arr.Count);
            Console.WriteLine((double)zero / arr.Count);
        }
    }
}