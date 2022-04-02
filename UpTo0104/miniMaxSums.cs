using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    public class miniMaxSums
    {
        public static void miniMaxSum(List<int> arr)
        {
            if (arr.Count == 0)
            {
                Console.WriteLine("0 0");
                return;
            }
            if (arr.Count == 1)
            {
                Console.WriteLine(arr[0] + " " + arr[0]);
                return;
            }
            if (arr.Count == 2)
            {
                Console.WriteLine(arr[0] + " " + arr[1]);
                return;
            }
            int Count = arr.Count - 1;
            arr.Sort();
            //Compute minimum sum of Count element in arr
            long min = 0;
            for (int i = 0; i < Count; i++)
            {
                min += arr[i];
            }
            //Compute maximum sum of Count element in arr
            long max = 0;
            for (int i = Count; i > 0; i--)
            {
                max += arr[i];
            }
            Console.WriteLine(min + " " + max);
        }
    }
}
