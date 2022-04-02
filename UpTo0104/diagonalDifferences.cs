using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    public class diagonalDifferences
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            if (arr.Count == 0)
            {
                return 0;
            }

            //Get the sum of The left to right diagonal
            int leftToRight = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        leftToRight += arr[i][j];
                    }
                }
            }
            //Get the sum of The right to left diagonal
            int rightToLeft = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == arr.Count - j - 1)
                    {
                        rightToLeft += arr[i][j];
                    }
                }
            }

            return Math.Abs(leftToRight - rightToLeft);


            return 0;
        }
    }
}
