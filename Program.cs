using Challenges;

int t = Convert.ToInt32(Console.ReadLine().Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    int n = Convert.ToInt32(Console.ReadLine().Trim());

    List<string> grid = new List<string>();

    for (int i = 0; i < n; i++)
    {
        string gridItem = Console.ReadLine();
        grid.Add(gridItem);
    }

    string result = gridChallengeClass.gridChallenge(grid);

    Console.WriteLine(result);
}
