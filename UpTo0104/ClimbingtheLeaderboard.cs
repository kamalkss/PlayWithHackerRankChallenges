

public class ClimbingtheLeaderboards
{
    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        var Result = new List<int>();
        //make ranked List distict
        var rankedDistinct = ranked.Distinct().ToList();

        foreach (var Alicescore in player)
        {
            //Compare AliceScore with each element in rankedDistinct
            //var rank = rankedDistinct.Count(x => x > Alicescore);
            int counter = 0;
            for (int i = 0; i < rankedDistinct.Count; i++)
            {
                
                if (rankedDistinct[i]>Alicescore)
                    counter++;
            }
            Result.Add(counter + 1);
        }

        /*for (int i = 0; i < player.Count; i++)
            {
                var playerScore = player[i];
                if (rankedDistinct.Contains(playerScore))
                {
                    Result.Add(rankedDict[playerScore]);
                }
                else
                {
                    var rank = 0;
                    var rankIndex = 0;
                    var rankValue = 0;
                    foreach (var item in rankedDistinct)
                    {
                        if (item < playerScore)
                        {
                            rankIndex++;
                        }
                        else
                        {
                            rankValue = item;
                            break;
                        }
                    }
                    if (rankValue == 0)
                    {
                        rank = rankedDistinct.Count + 1;
                    }
                    else
                    {
                        rank = rankedDict[rankValue] - rankIndex;
                    }
                    Result.Add(rank);
                }
            }*/


        /*var Result = new List<int>();
            var rankedDistinct = ranked.Distinct().ToList();
            var rankedDict = new Dictionary<int, int>();
            for (int i = 0; i < rankedDistinct.Count; i++)
            {
                rankedDict.Add(rankedDistinct[i], i + 1);
            }

            foreach (var position in player.Select(score => rankedDict.Where(x => x.Key <= score).OrderByDescending(x => x.Key).FirstOrDefault()))
            {
                if (position.Key == 0)
                {
                    Result.Add(rankedDict.Count + 1);
                }
                else
                {
                    Result.Add(position.Value);
                }
            }*/

        //rankedDistinct list distinct to Dense Ranking RankedDictionary
        var RankedDictionary = new Dictionary<int, int>();
        for (int i = 0; i < rankedDistinct.Count; i++)
        {
            RankedDictionary.Add(rankedDistinct[i], i + 1);
        }


        foreach (var score in player)
        {
            //compare score with every Score in RankedDictionary
            var rank = RankedDictionary.Count(pair => pair.Key > score) + 1;
            Result.Add(rank);
        }

        return Result;
    }
}