using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class flippingMatrixs
    {
        public static int flippingMatrix(List<List<int>> matrix)
        {
            var count = matrix.Count();
            var sum = 0;
            for (int i = 0; i < count/2; i++)
            {
                for (int j = 0; j < count/2; j++)
                {
                    List<int> CheckMax = new List<int>();
                    CheckMax.Add(matrix[i][j]);
                    CheckMax.Add(matrix[i][count - j - 1]);
                    CheckMax.Add(matrix[count - i - 1][j]);
                    CheckMax.Add(matrix[count - i - 1][count - j - 1]);

                    sum += CheckMax.Max();
                }
            }

            return sum;
        }
    }
}
