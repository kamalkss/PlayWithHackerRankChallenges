using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges
{
    public class miniMaxSum
    {
        public static void miniMaxSums(List<long> arr)
        {
            switch (arr.Count)
            {
                case 0:
                    Console.WriteLine(0 + " " + 0);
                    break;
                case 1:
                    Console.WriteLine(arr[0]+" " + arr[0]);
                    break;
                case 2:
                    arr.Sort();
                    Console.WriteLine(arr[0] +" " + arr[1]);
                    break;
                default:
                {
                    Int64 sum = 0;
                    List<Int64> sorted = new List<Int64>();
                    for (int i = 0; i < arr.Count; i++)
                    {
                        for (int j = 0; j < arr.Count; j++)
                        {
                            if (j != i)
                            {
                                sum += Convert.ToInt64(arr[j]);
                            }
                        }
                        sorted.Add(sum);
                        sum = 0;
                    }
                    sorted.Sort();
                    Console.WriteLine(sorted[0] + " " + sorted[sorted.Count - 1]);
                    break;
                }
            }
        }

    }
}