using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class ClimbingTheLeaderBoardClass
    {
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            var Result = new List<int>();
            Stack<long> scores = new Stack<long>();
            //distinct ranked scores to score stack
            foreach (var item in ranked.Distinct())
            {
                scores.Push(item);
            }
            //loop through player scores
            foreach (var score in player)
            {
                while (scores.Count > 0 && score >= scores.Peek())
                {
                    scores.Pop();
                }
                Result.Add(scores.Count + 1);
            }

            return Result;
        }
    }
}
