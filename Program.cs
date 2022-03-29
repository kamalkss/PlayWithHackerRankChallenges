



using Challenges;

Console.WriteLine(TheMaximumSubarray.run(new int[]{ 10, 14, 52, -2, 10, -22, -40, -3, 11 }));


switch (MathChallenge(8, 8))
{
    case -1:
        Console.WriteLine("-1");
        break;
    case 1:
        Console.WriteLine("true");
        break;
    case 0:
        Console.WriteLine("false");
        break;
}



static int MathChallenge(int num1, int num2)
{

    if (num1 == num2)
    {
        return -1;
    }
    return num1 > num2 ? 1 : 0;

}