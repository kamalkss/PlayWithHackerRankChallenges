using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class gridChallengeClass
    {
        public static string gridChallenge(List<string> grid)
        {
            bool isValid = true;

            for (int i = 0; i < grid.Count; i++)
            {
                grid[i] = String.Concat(grid[i].OrderBy(c => c));
            }


            for (int i = 0; i < grid[0].Length; i++)
            {
                List<char> column = grid.Select(t => t[i]).ToList();
                var sortedColumn = column.OrderBy(c => c).ToList();
                if (column.SequenceEqual(sortedColumn)) continue;
                isValid = false;
                break;
            }

            return isValid ? "YES" : "NO";
        }
    }
}
