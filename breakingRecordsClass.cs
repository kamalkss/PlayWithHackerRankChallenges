using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class breakingRecordsClass
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            List<int> Result = new List<int>();
            int HighestScore = scores[0];
            int highestScoreCount = 0;
            int LowestScore = scores[0];
            int lowestScoreCount = 0;
            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > HighestScore)
                {
                    highestScoreCount++;
                    HighestScore = scores[i];
                }
                if (scores[i] < LowestScore)
                {
                    LowestScore = scores[i];
                    lowestScoreCount++;
                }
            }
            Result.Add(highestScoreCount);
            Result.Add(lowestScoreCount);
            return Result;
        }
    }
}
