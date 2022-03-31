using Challenges;



// get A and B from Console.Realine

int q = Convert.ToInt32(Console.ReadLine().Trim());

for (int qItr = 0; qItr < q; qItr++)
{
    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int n = Convert.ToInt32(firstMultipleInput[0]);

    int k = Convert.ToInt32(firstMultipleInput[1]);

    List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

    List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

    string result = twoArrays.twoArray(k, A, B);
    Console.WriteLine(result);
}



