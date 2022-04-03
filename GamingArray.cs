using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class GamingArray
    {
        public static string gamingArray(List<int> arr)
        {
            //var result = 0;
            //while (arr.Count > 0)
            //{
            //    result++;
            //    arr.RemoveRange(arr.IndexOf(arr.Max()), (arr.Count) - arr.IndexOf(arr.Max()));
            //} 

            //return result % 2 == 0 ? "ANDY" : "BOB";

            //var result = 0;
            //while (arr.Count > 0)
            //{
            //    result++;
            //    var count = arr.Count;
            //    var indexofMax = arr.IndexOf(arr.Max());
            //    arr.RemoveRange(indexofMax,count-indexofMax);
            //}
            //return result % 2 == 0 ? "ANDY" : "BOB";

            Stack<int> ResultStack = new Stack<int>();
            foreach (var i in arr)
            {
                if (ResultStack.Count != 0 && ResultStack.Peek() > i)
                {
                    continue;
                }
                ResultStack.Push(i);
            }
            return ResultStack.Count % 2 == 0 ? "ANDY" : "BOB";
        }
    }
}
