

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