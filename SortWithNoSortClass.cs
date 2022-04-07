using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges
{
    public class SortWithNoSortClass
    {
        public static List<int> MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr.ToList();
            }
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            int middle = arr.Length / 2;
            for (int i = 0; i < middle; i++)
            {
                Left.Add(arr[i]);
            }
            for (int i = middle; i < arr.Length; i++)
            {
                Right.Add(arr[i]);
            }

            Left = MergeSort(Left.ToArray()).ToList();
            Right = MergeSort(Right.ToArray()).ToList();
            return Mege(Left, Right);
        }
        public static List<int> Mege(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            return result;
        }
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        
    }
}