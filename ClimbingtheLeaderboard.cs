using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges
{
    public class ClimbingtheLeaderboards
    {
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> Result = new List<int>();
            // Dense Ranking

            int Alice = 0;
            int AlicePosition = ranked.IndexOf(ranked.Max()) + 1;
            foreach (var score in player)
            {
                Alice += score;

                for (int i = 0; i < ranked.Count; i++)
                {
                    if (Alice > ranked[i])
                    {
                        Console.WriteLine(ranked[i]);
                        AlicePosition++;
                    }
                    else if (Alice == ranked[i])
                    {
                        Result.Add(ranked.IndexOf(ranked[i]));
                    }
                    else
                    {
                        break;
                    }
                }

                foreach (var LeaderScore in ranked)
                {
                    //check alice position
                    if (Alice > LeaderScore)
                    {
                        AlicePosition++;
                        Result.Add(AlicePosition);
                    }
                    else if (Alice == LeaderScore)
                    {
                        break;
                    }
                }
            }
            return Result;
        }

    }
}