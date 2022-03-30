using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class countApplesAndOranges
    {
        public static void a_countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            Console.WriteLine(apples.Count(apple => apple + a >= s && apple + a <= t));
            Console.WriteLine(oranges.Count(orange => orange + b <= t && orange + b >= s));
        }
    }
}
